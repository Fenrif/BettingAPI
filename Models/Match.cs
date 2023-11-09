using System.ComponentModel.DataAnnotations;
using BettingAPI.Enums;

namespace BettingAPI.Models
{
    public class Match
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime MatchDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime MatchTime { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public Sport Sport { get; set; }
        public virtual ICollection<MatchOdds> MatchOdds { get; set; } //Navigation property to MatchOdds
    }
}