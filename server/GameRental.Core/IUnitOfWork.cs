using System.Threading.Tasks;
using GameRental.Core.Repositories;

namespace GameRental.Core
{
    public interface IUnitOfWork
    {
        IGameRepository Games { get; }
        IPublisherRepository Publishers { get; }
        IGameGenrePivotRepository GameGenrePivot { get; }
        Task<int> CommitAsync();
    }
}