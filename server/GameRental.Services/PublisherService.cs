using System.Collections.Generic;
using System.Threading.Tasks;
using GameRental.Core;
using GameRental.Core.Models;
using GameRental.Core.Services;

namespace GameRental.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PublisherService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Publisher> CreatePublisher(Publisher publisher)
        {
            await _unitOfWork.Publishers.AddAsync(publisher);
            return publisher;
        }

        public async Task DeletePublisher(Publisher publisher)
        {
            _unitOfWork.Publishers.Remove(publisher);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _unitOfWork.Publishers.GetAllAsync();
        }

        public async Task<Publisher> GetPublisherById(int id)
        {
            return await _unitOfWork.Publishers.GetByIdAsync(id);
        }

        public async Task UpdatePublisher(Publisher publisherToUpdate, Publisher publisher)
        {
            publisherToUpdate.Name = publisher.Name;
            await _unitOfWork.CommitAsync();
        }
    }
}