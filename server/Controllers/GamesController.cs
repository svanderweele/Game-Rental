using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public GamesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult ListGames()
        {
            return Ok(new[] { "Viewtiful Joe 2", "Uncharted 4" });
        }

    }
}
