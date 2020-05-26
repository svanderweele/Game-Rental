using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameRental.Core.Models;
using GameRental.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GameRental.Data.Repositories
{
    public class GameGenrePivotRepository : Repository<GameGenrePivot>, IGameGenrePivotRepository
    {
        public GameGenrePivotRepository(GameRentalDbContext context)
           : base(context)
        { }

        private GameRentalDbContext GameRentalDbContext
        {
            get { return Context as GameRentalDbContext; }
        }


    }
}