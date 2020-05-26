using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GameRental.Api.Resources;
using GameRental.Api.Validators;
using GameRental.Core.Models;
using GameRental.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;

        public GamesController(IGameService gameService, IMapper mapper)
        {
            _gameService = gameService;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<GameResource>>> GetAllGames()
        {
            var games = await _gameService.GetAllWithPublisher();
            var gameResources = _mapper.Map<IEnumerable<Game>, IEnumerable<GameResource>>(games);
            return Ok(gameResources);
        }

        [HttpPost("")]
        public async Task<ActionResult<GameResource>> CreateGame([FromBody] SaveGameResource saveGameResource)
        {
            var validator = new SaveGameResourceValidator();
            var validationResult = await validator.ValidateAsync(saveGameResource);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors); // this needs refining, but for demo it is ok

            var gameToCreate = _mapper.Map<SaveGameResource, Game>(saveGameResource);
            
            var newGame = await _gameService.CreateGame(gameToCreate);
            await _gameService.SetGameGenres(newGame, saveGameResource.GenreIds);

            var game = await _gameService.GetGameByRef(newGame.Ref);

            var musicResource = _mapper.Map<Game, GameResource>(game);

            return Ok(musicResource);

        }
    }
}