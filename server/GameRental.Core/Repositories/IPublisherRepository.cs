using System.Collections.Generic;
using System.Threading.Tasks;
using GameRental.Core.Models;

namespace GameRental.Core.Repositories
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        Task<IEnumerable<Publisher>> GetAllWithGamesAsync();
        Task<Publisher> GetWithGamesAsync(int publisherId);
        
    }
}