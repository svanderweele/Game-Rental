using System.Threading.Tasks;
using GameRental.Core;
using GameRental.Core.Repositories;
using GameRental.Data.Repositories;

namespace GameRental.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameRentalDbContext _context;
        private GameRepository _gameRepository;
        private GameGenrePivotRepository _gameGenreRepository;
        private PublisherRepository _publisherRepository;

        public IGameRepository Games => _gameRepository = _gameRepository ?? new GameRepository(_context);
        public IPublisherRepository Publishers => _publisherRepository = _publisherRepository ?? new PublisherRepository(_context);
        public IGameGenrePivotRepository GameGenrePivot => _gameGenreRepository = _gameGenreRepository ?? new GameGenrePivotRepository(_context);
        
        public UnitOfWork(GameRentalDbContext context)
        {
            _context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}