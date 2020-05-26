using System.Threading.Tasks;
using GameRental.Core.Repositories;

namespace GameRental.Core{
    public interface IUnitOfWork
    {
        IGameRepository GameRepository{get;}
        Task<int> CommitAsync();   
    }
}