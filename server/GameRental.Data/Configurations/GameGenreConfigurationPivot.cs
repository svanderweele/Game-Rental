
using GameRental.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameRental.Data.Configurations
{
    public class GameGenrePivotConfiguration : IEntityTypeConfiguration<GameGenrePivot>
    {
        public void Configure(EntityTypeBuilder<GameGenrePivot> builder)
        {
            builder
                .HasKey(bc => new { bc.GameId, bc.GenreId });

            builder
                .HasOne(bc => bc.Game)
                .WithMany(b => b.Genres)
                .HasForeignKey(bc => bc.GameId);

            // builder.HasOne(m => m.Genre)
            //     .WithMany(m => m.Genres)
            //     .HasForeignKey(m => m.GenreId);
                
            builder
            .ToTable("GameGenresPivot");
        }
    }
}
