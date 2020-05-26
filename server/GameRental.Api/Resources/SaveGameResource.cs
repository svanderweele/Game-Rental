using System;
using System.Collections.Generic;
using GameRental.Core.Models;

namespace GameRental.Api.Resources
{
    public class SaveGameResource
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverArtUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int[] GenreIds { get; set; }

        public int PublisherId { get; set; }
    }
}