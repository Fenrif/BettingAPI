using BettingAPI.Dtos.Match;
using BettingAPI.Models;

namespace BettingAPI.Services.MatchService
{
    public interface IMatchService
    {
        Task<ServiceResponse<List<GetMatchDto>>> DeleteMatch(Guid id);
        Task<ServiceResponse<List<GetMatchDto>>> GetAllMatches();
        Task<ServiceResponse<GetMatchDto>> GetMatchById(Guid id);
        Task<ServiceResponse<List<GetMatchDto>>> InsertMatch(InsertMatchDto newMatch);
        Task<ServiceResponse<GetMatchDto>> UpdateMatch(UpdateMatchDto updatedMatch);
    }
}