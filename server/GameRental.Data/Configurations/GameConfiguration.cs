using GameRental.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameRental.Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
            .UseMySqlIdentityColumn();

            builder.Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(100);


            builder.HasOne(m => m.Publisher)
            .WithMany(m => m.Games)
            .HasForeignKey(m => m.PublisherId);

            builder
            .ToTable("Games");
        }
    }
}