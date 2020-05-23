using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameRentalApi.Models;
using GameRentalApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GameRentalApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> _logger;
        private readonly IGameService _gameService;

        public GamesController(ILogger<GamesController> logger, IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> ListGames()
        {
            List<GameModel> games = new List<GameModel>();

            try
            {
                games = await _gameService.GetAllGames();
                _logger.LogInformation(MyLogEvents.GetItem, "Get List of Games {0}", games);
            }
            catch (Exception e)
            {
                throw e;
            }
            return Ok(games);
        }

        [HttpGet("{reference}")]
        public async Task<ActionResult<GameModel>> GetGameById([FromRoute] Guid reference)
        {
            GameModel game = null;
            try
            {
                game = await _gameService.GetGameByReference(reference);
                _logger.LogInformation(MyLogEvents.GetItem, "Get Game by reference {0}", game);
            }
            catch (Exception e)
            {
                if (e is GameService.GameNotFoundException)
                {
                    return NotFound();
                }
                throw e;
            }

            return Ok(GetGameResponse(game));
        }

        [HttpPost]
        public async Task<ActionResult<GameModel>> PostGame([FromBody] GameModel game)
        {
            try
            {
                await _gameService.CreateGame(game);
            }
            catch (Exception e)
            {
                if (e is GameService.GameCreationNotValidException)
                {
                    return BadRequest(e.Message);
                }
                throw e;
            }

            return CreatedAtAction(nameof(GetGameById), new { reference = game.Ref }, GetGameResponse(game));
        }



        private object GetGameResponse(GameModel model)
        {
            return new
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Publisher = model.Publisher,
                Ref = model.Ref
            };
        }

    }
}
