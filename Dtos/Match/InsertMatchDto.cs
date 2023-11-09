
using System.ComponentModel.DataAnnotations;
using BettingAPI.Enums;

namespace BettingAPI.Dtos.Match
{
    public class InsertMatchDto
    {
        public string Description { get; set; } = String.Empty;
        [DataType(DataType.Date)]
        public DateTime MatchDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime MatchTime { get; set; }
        public string TeamA { get; set; } = String.Empty;
        public string TeamB { get; set; } = String.Empty;
        public Sport Sport { get; set; }
    }
}