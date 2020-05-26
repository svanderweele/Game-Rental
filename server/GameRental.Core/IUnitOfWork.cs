using System.Threading.Tasks;
using GameRental.Core.Repositories;

namespace GameRental.Core
{
    public interface IUnitOfWork
    {
        IGameRepository Games { get; }
        IPublisherRepository Publishers { get; }
        Task<int> CommitAsync();
    }
}