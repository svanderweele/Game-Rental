using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameRental.Core;
using GameRental.Core.Models;
using GameRental.Core.Services;

namespace GameRental.Services
{
    public class GameService : IGameService
    {
        private IUnitOfWork _unitOfWork;

        public GameService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Game> CreateGame(Game game)
        {
            await _unitOfWork.Games.AddAsync(game);
            return game;
        }

        public async Task DeleteGame(Game game)
        {
            _unitOfWork.Games.Remove(game);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Game>> GetAllWithPublisher()
        {
            return await _unitOfWork.Games.GetAllWithPublisherAsync();
        }

        public async Task<Game> GetGameByRef(Guid reference)
        {
            return await _unitOfWork.Games.GetWithPublisherByRefAsync(reference);
        }

        public async Task UpdateGame(Game gameToUpdate, Game game)
        {
            gameToUpdate.Genres = game.Genres;
            gameToUpdate.Name = game.Name;
            gameToUpdate.Description = game.Description;
            gameToUpdate.PublisherId = game.PublisherId;
            gameToUpdate.ReleaseDate = game.ReleaseDate;
            gameToUpdate.CoverArtUrl = game.CoverArtUrl;
            
            await _unitOfWork.CommitAsync();
        }
    }
}