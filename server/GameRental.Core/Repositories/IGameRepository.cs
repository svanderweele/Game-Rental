using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameRental.Core.Models;

namespace GameRental.Core.Repositories
{
    public interface IGameRepository : IRepository<Game>
    {
        Task<IEnumerable<Game>> GetAllWithPublisherAsync();
        Task<Game> GetWithPublisherAsync(Guid id);
        Task<IEnumerable<Game>> GetAllWithPublisherByPublisherIdAsync(int publisherId);
    }
}