using BettingAPI.Enums;

namespace BettingAPI.Dtos.MatchOdds
{
    public class InsertMatchOddsDto
    {
        public Guid MatchID { get; set; }
        public OddSpecifier Specifier { get; set; }
        public decimal Odd { get; set; }
        public virtual Models.Match Match { get; set; } //Navigation property to Match
    }
}