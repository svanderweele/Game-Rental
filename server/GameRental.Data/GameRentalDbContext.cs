using System;
using System.Linq;
using System.Threading.Tasks;
using GameRental.Core.Models;
using GameRental.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GameRental.Data
{
    public class GameRentalDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public GameRentalDbContext(DbContextOptions<GameRentalDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new GameConfiguration());
            builder
                .ApplyConfiguration(new PublisherConfiguration());
            builder
                .ApplyConfiguration(new GameGenreConfiguration());
            builder
                .ApplyConfiguration(new GameGenrePivotConfiguration());

            var seeder = new SeedConfiguration();
            seeder.Seed(builder);
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

            entries = ChangeTracker.Entries().Where(e => e.Entity is IReferable && (
                         e.State == EntityState.Added));

            foreach (var entityEntry in entries)
            {
                ((IReferable)entityEntry.Entity).Ref = Guid.NewGuid();
            }
        }
    }
}