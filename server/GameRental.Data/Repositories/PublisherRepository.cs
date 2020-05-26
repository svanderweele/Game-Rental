using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameRental.Core.Models;
using GameRental.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GameRental.Data.Repositories
{
    public class PublisherRepository : Repository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(GameRentalDbContext context)
           : base(context)
        { }

        private GameRentalDbContext GameRentalDbContext
        {
            get { return Context as GameRentalDbContext; }
        }

        public async Task<IEnumerable<Publisher>> GetAllWithGamesAsync()
        {
            return await GameRentalDbContext.Publishers
                .Include(m => m.Games)
                .ToListAsync();
        }

        public async Task<Publisher> GetWithGamesAsync(int publisherId)
        {
            return await GameRentalDbContext.Publishers
                .Include(m => m.Games)
                .SingleOrDefaultAsync(m => m.Id == publisherId);
        }
    }
}