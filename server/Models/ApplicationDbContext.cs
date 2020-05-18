using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GameRentalApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSave();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            OnBeforeSave();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSave()
        {
            ChangeTracker.DetectChanges();

            var entries = ChangeTracker.Entries().Where(e => e.Entity is ISoftDeletes && (
             e.State == EntityState.Added
             || e.State == EntityState.Modified || e.State == EntityState.Deleted));

            foreach (var entityEntry in entries)
            {
                ((ISoftDeletes)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((ISoftDeletes)entityEntry.Entity).CreatedAt = DateTime.Now;
                    ((ISoftDeletes)entityEntry.Entity).DeletedAt = null;
                }

                if (entityEntry.State == EntityState.Deleted)
                {
                    ((ISoftDeletes)entityEntry.Entity).DeletedAt = DateTime.Now;
                    entityEntry.State = EntityState.Unchanged;
                }
            }

            entries = ChangeTracker.Entries().Where(e => e.Entity is IReferenceable && (
                         e.State == EntityState.Added));

            foreach (var entityEntry in entries)
            {
                ((IReferenceable)entityEntry.Entity).Ref = Guid.NewGuid();
            }
        }



        public DbSet<GameModel> Games { get; set; }
        public DbSet<PublisherModel> Publishers { get; set; }
    }
}