using Microsoft.EntityFrameworkCore;

namespace GameRental.Data.Configurations
{
    public interface ISeedConfiguration
    {
        void Seed(ModelBuilder builder);
    }
}