using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameRentalApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GameRentalApi.Services
{
    public interface IGameService
    {
        Task<GameModel> GetGameByReference(Guid reference);
        Task<GameModel> CreateGame(GameModel model);
        Task<List<GameModel>> GetAllGames();
    }
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<GameService> _logger;

        public GameService(ApplicationDbContext context, ILogger<GameService> logger)
        {
            _context = context;
            _context.Database.EnsureCreated();
            _logger = logger;
        }

        public class GameNotFoundException : Exception
        {
            public GameNotFoundException(Guid reference) : base($"Game with ref {reference} not found.")
            {
            }
        }


        public class GameCreationNotValidException : Exception
        {
            public GameCreationNotValidException(string message) : base(message)
            {
            }
        }



        public async Task<GameModel> CreateGame(GameModel game)
        {
            if (game == null)
            {
                throw new GameCreationNotValidException("Model is null.");
            }

            _context.Games.Add(game);
            _logger.LogInformation(MyLogEvents.GetItem, "Adding game {0}.", game);
            await _context.SaveChangesAsync();

            game = await _context.Games.Include(e => e.Publisher).FirstOrDefaultAsync(e => e.Id == game.Id);
            _logger.LogInformation(MyLogEvents.GetItem, "Added game {0}.", game.Id);


            return game;
        }

        public async Task<GameModel> GetGameByReference(Guid reference)
        {
            GameModel game = await _context.Games.Include(e => e.Publisher).FirstOrDefaultAsync(e => e.Ref == reference);
            if (game == null)
            {
                throw new GameNotFoundException(game.Ref);
            }

            return game;
        }

        public async Task<List<GameModel>> GetAllGames()
        {
            List<GameModel> games = await _context.Games.Include(e => e.Publisher).ToListAsync();
            return games;
        }
    }
}