using Microsoft.EntityFrameworkCore;

namespace GameRentalApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

        }


        public DbSet<GameModel> Games{get;set;}
        public DbSet<PublisherModel> Publishers{get;set;}
    }
}