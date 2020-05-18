using System.Threading.Tasks;
using GameRentalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> _logger;
        private readonly ApplicationDbContext _context;

        public GamesController(ILogger<GamesController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ListGames()
        {
            var games = _context.Games.Include(e => e.Publisher);
            _logger.LogInformation(MyLogEvents.GetItem, "Get List of Games {0}", games);
            return Ok(await games.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGameById([FromRoute] int id)
        {
            var game = await _context.Games.Include(e => e.Publisher).FirstOrDefaultAsync(e => e.Id == id);
            _logger.LogInformation(MyLogEvents.GetItem, "Get List of Games {0}", game);
            return Ok(new {
                Id = game.Id,
                Name = game.Name,
                Description = game.Description,
                Publisher = game.Publisher
            });
        }

        // [HttpPost]
        // public async Task<IActionResult> PostGame()
        // {
        //     var games = _context.Games.Include(e => e.Publisher);
        //     _logger.LogInformation(MyLogEvents.GetItem, "Get List of Games {0}", games);
        //     return Ok(await games.ToListAsync());
        // }

    }
}
