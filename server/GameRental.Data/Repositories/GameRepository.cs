using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameRental.Core.Models;
using GameRental.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GameRental.Data.Repositories
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(GameRentalDbContext context)
           : base(context)
        { }

        private GameRentalDbContext GameRentalDbContext
        {
            get { return Context as GameRentalDbContext; }
        }

        public async Task<IEnumerable<Game>> GetAllWithPublisherAsync()
        {
            return await GameRentalDbContext.Games
                .Include(m => m.Genres)
                .ThenInclude(m => m.Genre)
                .Include(e => e.Publisher)
                .ToListAsync();
        }

        public async Task<IEnumerable<Game>> GetAllWithPublisherByPublisherIdAsync(int publisherId)
        {
            return await GameRentalDbContext.Games
                .Include(m => m.Genres)
                .ThenInclude(m => m.Genre)
                .Include(m => m.Publisher)
                .Where(m => m.PublisherId == publisherId)
                .ToListAsync();
        }

        public async ValueTask<Game> GetWithPublisherByRefAsync(Guid reference)
        {
            return await GameRentalDbContext.Games.SingleOrDefaultAsync(m => m.Ref == reference);
        }

        public async Task<Game> GetWithPublisherAsync(Guid id)
        {
            return await GameRentalDbContext.Games
                .Include(m => m.Genres)
                .ThenInclude(m => m.Genre)
                 .Include(m => m.Publisher)
                 .SingleOrDefaultAsync(m => m.Ref == id);
        }
    }
}