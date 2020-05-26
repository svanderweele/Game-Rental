using System.Collections.Generic;

namespace GameRental.Core.Models
{
    public class GameGenre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // public ICollection<GameGenrePivot> Genres { get; set; }
    }
}