using GameRental.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameRental.Data.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseMySqlIdentityColumn();

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);


            //CHECK :: Do we need this since it is defined in GameConfiguration.cs?
            // builder.HasMany(m => m.Games)
            //     .WithOne(m => m.Publisher)
            //     .HasForeignKey(m => m.PublisherId);

            builder
                .ToTable("Publishers");
        }
    }
}