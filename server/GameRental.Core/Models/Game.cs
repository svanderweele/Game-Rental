using System;
using System.Collections.Generic;

namespace GameRental.Core.Models
{
    public class Game : IReferable, ISoftDeletes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverArtUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<GameGenrePivot> Genres{get;set;}

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public Guid Ref { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}