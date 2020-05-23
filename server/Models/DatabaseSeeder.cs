using System;
using Microsoft.EntityFrameworkCore;

namespace GameRentalApi.Models
{
    public static class DatabaseSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublisherModel>().HasData(
                new PublisherModel { Id = 1, Name = "Sony Interactive Entertainment", Ref = Guid.NewGuid() },
                new PublisherModel { Id = 2, Name = "Capcom", Ref = Guid.NewGuid() }
            );

            modelBuilder.Entity<GameModel>().HasData(
                new GameModel { Id = 1, Ref = Guid.NewGuid(), Name = "Uncharted: Drake's Fortune", Description = "Uncharted: Drake's Fortune is a 2007 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the first game in the Uncharted series, and was released in November 2007 for PlayStation 3. Combining action-adventure and platforming elements with a third-person perspective, the game follows Nathan Drake, the supposed descendant of the explorer Sir Francis Drake, as he seeks the lost treasure of El Dorado, with the help of journalist Elena Fisher and mentor Victor Sullivan.[1]", ImageUrl = "https://en.wikipedia.org/wiki/Uncharted:_Drake%27s_Fortune#/media/File:Uncharted_Drake's_Fortune.jpg", PublisherId = 1 },
                new GameModel { Id = 2, Ref = Guid.NewGuid(), Name = "Uncharted 2: Among Thieves", Description = "Uncharted 2: Among Thieves is a 2009 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the second game in the Uncharted series, and was released in October 2009 for PlayStation 3. Set two years after the events of Drake's Fortune, the single-player story follows Nathan Drake, who partners with Chloe Frazer and Elena Fisher, as they search for the Cintamani Stone and Shambhala, whilst battling a mercenary group led by Zoran Lazarević and Harry Flynn.", ImageUrl = "https://en.wikipedia.org/wiki/Uncharted:_Drake%27s_Fortune#/media/File:Uncharted_Drake's_Fortune.jpg", PublisherId = 1 });



        }
    }
}