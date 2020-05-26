using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GameRental.Api.Resources;
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
    }
}