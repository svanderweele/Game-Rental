using System.Collections.Generic;
using System.Threading.Tasks;
using GameRental.Core.Models;

namespace GameRental.Core.Services
{
    public interface IPublisherService
    {
        Task<IEnumerable<Publisher>> GetAllPublishers();
        Task<Publisher> GetPublisherById(int id);
        Task<Publisher> CreatePublisher(Publisher publisher);
        Task UpdatePublisher(Publisher publisherToUpdate, Publisher publisher);
        Task DeletePublisher(Publisher publisher);
    }
}