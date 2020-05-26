using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameRental.Core.Models
{
    public class Publisher
    {


        public Publisher()
        {
            Games = new Collection<Game>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}