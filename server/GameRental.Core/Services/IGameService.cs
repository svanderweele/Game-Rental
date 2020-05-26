using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameRental.Core.Models;

namespace GameRental.Core.Services{
    public interface IGameService{

        Task<IEnumerable<Game>> GetAllWithPublisher();
        Task<Game> GetGameByRef(Guid reference);
        Task<Game> CreateGame(Game game);
        Task UpdateGame(Game gameToUpdate, Game game);
        Task DeleteGame(Game game);
    }
}