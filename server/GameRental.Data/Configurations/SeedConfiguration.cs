using System;
using System.Collections.Generic;
using GameRental.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GameRental.Data.Configurations
{
    public class SeedConfiguration : ISeedConfiguration
    {
        public void Seed(ModelBuilder builder)
        {
            var publishers = new List<Publisher>(){
                new Publisher{
                Id = 1,
                Name = "Sony Interactive Entertainment",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
                }
            };

            var games = new List<Game>(){
                new Game{
                Id = 1,
                Ref = Guid.NewGuid(),
                PublisherId = publishers[0].Id,
                CoverArtUrl = "https://en.wikipedia.org/wiki/Uncharted:_Drake%27s_Fortune#/media/File:Uncharted_Drake's_Fortune.jpg",
                Name = "Uncharted: Drake's Fortune",
                Description="Uncharted: Drake's Fortune is a 2007 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the first game in the Uncharted series, and was released in November 2007 for PlayStation 3. Combining action-adventure and platforming elements with a third-person perspective, the game follows Nathan Drake, the supposed descendant of the explorer Sir Francis Drake, as he seeks the lost treasure of El Dorado, with the help of journalist Elena Fisher and mentor Victor Sullivan.[1]",
                Genres = new []{GameGenre.ActionAdventure, GameGenre.ThirdPersonShooter, GameGenre.Platformer},
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ReleaseDate = new DateTime(2007, 11, 20)}
            };


            builder.Entity<Game>().HasData(games);
            builder.Entity<Publisher>().HasData(publishers);
        }
    }
}