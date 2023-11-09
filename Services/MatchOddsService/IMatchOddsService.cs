using BettingAPI.Dtos.MatchOdds;
using BettingAPI.Models;

namespace BettingAPI.Services.MatchOddsService
{
    public interface IMatchOddsService
    {
        Task<ServiceResponse<List<GetMatchOddsDto>>> DeleteMatch(Guid id);
        Task<ServiceResponse<List<GetMatchOddsDto>>> GetAllMatchOdds();
        Task<ServiceResponse<GetMatchOddsDto>> GetMatchOddById(Guid id);
        Task<ServiceResponse<List<GetMatchOddsDto>>> InsertMatchOdd(InsertMatchOddsDto newMatchOdd);
        Task<ServiceResponse<GetMatchOddsDto>> UpdateMatchOdd(UpdateMatchOddsDto updatedMatchOdd);
    }
}