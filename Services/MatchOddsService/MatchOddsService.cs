using AutoMapper;
using BettingAPI.Data;
using BettingAPI.Dtos.MatchOdds;
using BettingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingAPI.Services.MatchOddsService
{
    public class MatchOddsService : IMatchOddsService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public MatchOddsService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetMatchOddsDto>>> DeleteMatch(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<GetMatchOddsDto>>();

            try
            {
                var matchOdd = await _context.MatchOdds.FirstOrDefaultAsync(m => m.ID == id);
                if (matchOdd is null)
                {
                    throw new Exception($"Match Odd with Id '{id}' not found.");
                }

                _context.MatchOdds.Remove(matchOdd);
                await _context.SaveChangesAsync();

                serviceResponse.Data = await _context.MatchOdds.Select(m => _mapper.Map<GetMatchOddsDto>(m)).ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetMatchOddsDto>>> GetAllMatchOdds()
        {
            var serviceResponse = new ServiceResponse<List<GetMatchOddsDto>>();
            var matchOdds = await _context.MatchOdds.ToListAsync();
            serviceResponse.Data = matchOdds.Select(m => _mapper.Map<GetMatchOddsDto>(m)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetMatchOddsDto>> GetMatchOddById(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetMatchOddsDto>();
            var matchOdd = await _context.MatchOdds.FirstOrDefaultAsync(m => m.ID == id);
            serviceResponse.Data = _mapper.Map<GetMatchOddsDto>(matchOdd);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetMatchOddsDto>>> InsertMatchOdd(InsertMatchOddsDto newMatchOdd)
        {
            var serviceResponse = new ServiceResponse<List<GetMatchOddsDto>>();
            var matchOdd = _mapper.Map<MatchOdds>(newMatchOdd);
            matchOdd.ID = Guid.NewGuid();
            _context.MatchOdds.Add(matchOdd);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.MatchOdds.Select(m => _mapper.Map<GetMatchOddsDto>(m)).ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetMatchOddsDto>> UpdateMatchOdd(UpdateMatchOddsDto updatedMatchOdd)
        {
            var serviceResponse = new ServiceResponse<GetMatchOddsDto>();
            try
            {
                var matchOdds = await _context.MatchOdds.ToListAsync();
                var matchOdd = matchOdds.FirstOrDefault(m => m.ID == updatedMatchOdd.ID);
                if (matchOdd is null)
                {
                    throw new Exception($"Match Odd with Id '{updatedMatchOdd.ID}' not found.");
                }

                _mapper.Map(updatedMatchOdd, matchOdd);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<GetMatchOddsDto>(matchOdd);

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