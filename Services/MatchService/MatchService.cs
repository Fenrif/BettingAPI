using AutoMapper;
using BettingAPI.Data;
using BettingAPI.Dtos.Match;
using BettingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingAPI.Services.MatchService
{
    public class MatchService : IMatchService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public MatchService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetMatchDto>>> DeleteMatch(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetMatchDto>>();

            try
            {
                var match = await _context.Match.FirstOrDefaultAsync(m => m.ID == id);
                if (match is null)
                {
                    throw new Exception($"Match with Id '{id}' not found.");
                }

                _context.Match.Remove(match); //cascade delete
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.Match.Select(m => _mapper.Map<GetMatchDto>(m)).ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetMatchDto>>> GetAllMatches()
        {
            var serviceResponse = new ServiceResponse<List<GetMatchDto>>();
            var matches = await _context.Match.ToListAsync();
            serviceResponse.Data = matches.Select(m => _mapper.Map<GetMatchDto>(m)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetMatchDto>> GetMatchById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetMatchDto>();
            var match = await _context.Match.FirstOrDefaultAsync(m => m.ID == id);
            serviceResponse.Data = _mapper.Map<GetMatchDto>(match);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetMatchDto>>> InsertMatch(InsertMatchDto newMatch)
        {
            var serviceResponse = new ServiceResponse<List<GetMatchDto>>();
            var match = _mapper.Map<Match>(newMatch);
            match.ID = Guid.NewGuid();
            _context.Match.Add(match);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.Match.Select(m => _mapper.Map<GetMatchDto>(m)).ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetMatchDto>> UpdateMatch(UpdateMatchDto updatedMatch)
        {
            var serviceResponse = new ServiceResponse<GetMatchDto>();
            try
            {
                var matches = await _context.Match.ToListAsync();
                var match = matches.FirstOrDefault(m => m.ID == updatedMatch.ID);
                if (match is null)
                {
                    throw new Exception($"Match with Id '{updatedMatch.ID}' not found.");
                }

                _mapper.Map(updatedMatch, match);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<GetMatchDto>(match);

                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }
    }
}