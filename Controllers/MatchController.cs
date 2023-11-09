using BettingAPI.Dtos.Match;
using BettingAPI.Models;
using BettingAPI.Services.MatchService;
using Microsoft.AspNetCore.Mvc;

namespace BettingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetMatchDto>>> Delete(Guid id)
        {
            var response = await _matchService.DeleteMatch(id);
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetMatchDto>>>> GetAll()
        {
            return Ok(await _matchService.GetAllMatches());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetMatchDto>>> Get(Guid id)
        {
            return Ok(await _matchService.GetMatchById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetMatchDto>>>> Insert(InsertMatchDto newMatch)
        {
            return Ok(await _matchService.InsertMatch(newMatch));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetMatchDto>>>> Update(UpdateMatchDto updatedMatch)
        {
            return Ok(await _matchService.UpdateMatch(updatedMatch));
        }
    }
}