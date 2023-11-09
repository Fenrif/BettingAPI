using BettingAPI.Dtos.MatchOdds;
using BettingAPI.Models;
using BettingAPI.Services.MatchOddsService;
using Microsoft.AspNetCore.Mvc;

namespace BettingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchOddsController : ControllerBase
    {
        private readonly IMatchOddsService _matchOddsService;

        public MatchOddsController(IMatchOddsService matchOddsService)
        {
            _matchOddsService = matchOddsService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetMatchOddsDto>>>> GetAll()
        {
            return Ok(await _matchOddsService.GetAllMatchOdds());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetMatchOddsDto>>> Get(Guid id)
        {
            return Ok(await _matchOddsService.GetMatchOddById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetMatchOddsDto>>>> Insert(InsertMatchOddsDto newMatch)
        {
            return Ok(await _matchOddsService.InsertMatchOdd(newMatch));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetMatchOddsDto>>>> Update(UpdateMatchOddsDto updatedMatch)
        {
            return Ok(await _matchOddsService.UpdateMatchOdd(updatedMatch));
        }
    }
}