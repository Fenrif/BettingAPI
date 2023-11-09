using System.ComponentModel.DataAnnotations.Schema;
using BettingAPI.Enums;

namespace BettingAPI.Models
{
    public class MatchOdds
    {
        public Guid ID { get; set; }
        // [ForeignKey("Match")]
        public Guid MatchID { get; set; }
        public OddSpecifier Specifier { get; set; }
        public decimal Odd { get; set; }
        public virtual Match Match { get; set; } //Navigation property to Match
    }
}