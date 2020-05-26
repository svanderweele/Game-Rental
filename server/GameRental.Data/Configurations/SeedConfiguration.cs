using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            var gameGenres = new List<GameGenre>(){
                new GameGenre{Id= 1, Name= "Action"},
                new GameGenre{Id= 2, Name= "Third Person Shooter"},
                new GameGenre{Id= 3, Name= "Platformer"},
                new GameGenre{Id= 4, Name= "Survival"},
                new GameGenre{Id= 5, Name= "Horror"},
            };

            var games = new List<Game>(){
                new Game{
                Id = 1,
                Ref = Guid.NewGuid(),
                PublisherId = publishers[0].Id,
                CoverArtUrl = "https://en.wikipedia.org/wiki/Uncharted:_Drake%27s_Fortune#/media/File:Uncharted_Drake's_Fortune.jpg",
                Name = "Uncharted: Drake's Fortune",
                Description="Uncharted: Drake's Fortune is a 2007 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the first game in the Uncharted series, and was released in November 2007 for PlayStation 3. Combining action-adventure and platforming elements with a third-person perspective, the game follows Nathan Drake, the supposed descendant of the explorer Sir Francis Drake, as he seeks the lost treasure of El Dorado, with the help of journalist Elena Fisher and mentor Victor Sullivan.[1]",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ReleaseDate = new DateTime(2007, 11, 20)},
                new Game{
                Id = 2,
                Ref = Guid.NewGuid(),
                PublisherId = publishers[0].Id,
                CoverArtUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/Crash_Bandicoot_Cover.png",
                Name = "Crash Bandicoot",
                Description="Crash Bandicoot is a platform video game developed by Naughty Dog and published by Sony Computer Entertainment for the PlayStation. The game was released in North America in September 1996, and in Europe in November 1996.",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ReleaseDate = new DateTime(1996, 11, 08)}
            };

            var gameGenresPivot = new List<GameGenrePivot>(){
                new GameGenrePivot{GameId = 1, GenreId = 1},
                new GameGenrePivot{GameId = 1, GenreId = 2},
                new GameGenrePivot{GameId = 1, GenreId = 3},
                new GameGenrePivot{GameId = 2, GenreId = 3},
            };


            builder.Entity<GameGenre>().HasData(gameGenres);
            builder.Entity<GameGenrePivot>().HasData(gameGenresPivot);
            builder.Entity<Game>().HasData(games);
            builder.Entity<Publisher>().HasData(publishers);
        }
    }
}