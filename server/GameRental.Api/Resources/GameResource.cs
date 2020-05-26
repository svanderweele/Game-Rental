using System;
using System.Collections.Generic;
using GameRental.Core.Models;

namespace GameRental.Api.Resources
{
    public class GameResource
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverArtUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public PublisherResource Publisher { get; set; }
    }
}