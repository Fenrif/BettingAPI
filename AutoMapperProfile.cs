using AutoMapper;
using BettingAPI.Dtos.Match;
using BettingAPI.Dtos.MatchOdds;
using BettingAPI.Models;

namespace BettingAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Match, GetMatchDto>();
            CreateMap<InsertMatchDto, Match>();
            CreateMap<UpdateMatchDto, Match>();

            CreateMap<MatchOdds, GetMatchOddsDto>();
            CreateMap<InsertMatchOddsDto, MatchOdds>();
            CreateMap<UpdateMatchOddsDto, MatchOdds>();
        }
    }
}