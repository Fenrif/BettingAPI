using BettingAPI.Enums;

namespace BettingAPI.Dtos.MatchOdds
{
    public class GetMatchOddsDto
    {
        public Guid ID { get; set; }
        public Guid MatchID { get; set; }
        public OddSpecifier Specifier { get; set; }
        public decimal Odd { get; set; }
    }
}