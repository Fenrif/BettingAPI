using BettingAPI.Models;
using Microsoft.EntityFrameworkCore;
using Match = BettingAPI.Models.Match;

namespace BettingAPI.Data
{
    public class DbInitializer
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            #region Match Ids
            var matchID01 = Guid.NewGuid();
            var matchID02 = Guid.NewGuid();
            var matchID03 = Guid.NewGuid();
            var matchID04 = Guid.NewGuid();
            var matchID05 = Guid.NewGuid();
            var matchID06 = Guid.NewGuid();
            var matchID07 = Guid.NewGuid();
            var matchID08 = Guid.NewGuid();
            var matchID09 = Guid.NewGuid();
            var matchID10 = Guid.NewGuid();
            var matchID11 = Guid.NewGuid();
            var matchID12 = Guid.NewGuid();
            var matchID13 = Guid.NewGuid();
            var matchID14 = Guid.NewGuid();
            var matchID15 = Guid.NewGuid();
            var matchID16 = Guid.NewGuid();
            var matchID17 = Guid.NewGuid();
            var matchID18 = Guid.NewGuid();
            var matchID19 = Guid.NewGuid();
            var matchID20 = Guid.NewGuid();
            #endregion

            #region Matches
                
            modelBuilder.Entity<Match>().HasData(
                new Match
                {
                    ID = matchID01,
                    Description = "OSFP - PAO",
                    MatchDate = new DateTime(2023, 11, 1),
                    MatchTime = new DateTime(2023, 11, 1, 12, 0, 0),
                    TeamA = "OSFP",
                    TeamB = "PAO",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID02,
                    Description = "OSFP - PAO",
                    MatchDate = new DateTime(2023, 11, 2),
                    MatchTime = new DateTime(2023, 11, 2, 14, 30, 0),
                    TeamA = "OSFP",
                    TeamB = "PAO",
                    Sport = Enums.Sport.Basketball,
                },
                new Match
                {
                    ID = matchID03,
                    Description = "AEK - ARIS",
                    MatchDate = new DateTime(2023, 11, 3),
                    MatchTime = new DateTime(2023, 11, 3, 18, 0, 0),
                    TeamA = "AEK",
                    TeamB = "ARIS",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID04,
                    Description = "AEL - OFI",
                    MatchDate = new DateTime(2023, 11, 4),
                    MatchTime = new DateTime(2023, 11, 4, 20, 0, 0),
                    TeamA = "AEL",
                    TeamB = "OFI",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID05,
                    Description = "PAS - IRAKLIS",
                    MatchDate = new DateTime(2023, 11, 5),
                    MatchTime = new DateTime(2023, 11, 5, 15, 30, 0),
                    TeamA = "PAS",
                    TeamB = "IRAKLIS",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID06,
                    Description = "ATROMITOS - OSFP",
                    MatchDate = new DateTime(2023, 11, 6),
                    MatchTime = new DateTime(2023, 11, 6, 17, 0, 0),
                    TeamA = "ATROMITOS",
                    TeamB = "OSFP",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID07,
                    Description = "PAO - AEL",
                    MatchDate = new DateTime(2023, 11, 7),
                    MatchTime = new DateTime(2023, 11, 7, 19, 30, 0),
                    TeamA = "PAO",
                    TeamB = "AEL",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID08,
                    Description = "ARIS - AEK",
                    MatchDate = new DateTime(2023, 11, 8),
                    MatchTime = new DateTime(2023, 11, 8, 14, 0, 0),
                    TeamA = "ARIS",
                    TeamB = "AEK",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID09,
                    Description = "OFI - PAS",
                    MatchDate = new DateTime(2023, 11, 9),
                    MatchTime = new DateTime(2023, 11, 9, 16, 30, 0),
                    TeamA = "OFI",
                    TeamB = "PAS",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID10,
                    Description = "IRAKLIS - ATROMITOS",
                    MatchDate = new DateTime(2023, 11, 10),
                    MatchTime = new DateTime(2023, 11, 10, 18, 0, 0),
                    TeamA = "IRAKLIS",
                    TeamB = "ATROMITOS",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID11,
                    Description = "OSFP - PAO",
                    MatchDate = new DateTime(2023, 11, 11),
                    MatchTime = new DateTime(2023, 11, 11, 12, 0, 0),
                    TeamA = "OSFP",
                    TeamB = "PAO",
                    Sport = Enums.Sport.Basketball,
                },
                new Match
                {
                    ID = matchID12,
                    Description = "AEK - ARIS",
                    MatchDate = new DateTime(2023, 11, 12),
                    MatchTime = new DateTime(2023, 11, 12, 18, 0, 0),
                    TeamA = "AEK",
                    TeamB = "ARIS",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID13,
                    Description = "AEL - OFI",
                    MatchDate = new DateTime(2023, 11, 13),
                    MatchTime = new DateTime(2023, 11, 13, 20, 0, 0),
                    TeamA = "AEL",
                    TeamB = "OFI",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID14,
                    Description = "PAS - IRAKLIS",
                    MatchDate = new DateTime(2023, 11, 14),
                    MatchTime = new DateTime(2023, 11, 14, 15, 30, 0),
                    TeamA = "PAS",
                    TeamB = "IRAKLIS",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID15,
                    Description = "ATROMITOS - OSFP",
                    MatchDate = new DateTime(2023, 11, 15),
                    MatchTime = new DateTime(2023, 11, 15, 17, 0, 0),
                    TeamA = "ATROMITOS",
                    TeamB = "OSFP",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID16,
                    Description = "PAO - AEL",
                    MatchDate = new DateTime(2023, 11, 16),
                    MatchTime = new DateTime(2023, 11, 16, 19, 30, 0),
                    TeamA = "PAO",
                    TeamB = "AEL",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID17,
                    Description = "ARIS - AEK",
                    MatchDate = new DateTime(2023, 11, 17),
                    MatchTime = new DateTime(2023, 11, 17, 14, 0, 0),
                    TeamA = "ARIS",
                    TeamB = "AEK",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID18,
                    Description = "OFI - PAS",
                    MatchDate = new DateTime(2023, 11, 18),
                    MatchTime = new DateTime(2023, 11, 18, 16, 30, 0),
                    TeamA = "OFI",
                    TeamB = "PAS",
                    Sport = Enums.Sport.Basketball
                },
                new Match
                {
                    ID = matchID19,
                    Description = "IRAKLIS - ATROMITOS",
                    MatchDate = new DateTime(2023, 11, 19),
                    MatchTime = new DateTime(2023, 11, 19, 18, 0, 0),
                    TeamA = "IRAKLIS",
                    TeamB = "ATROMITOS",
                    Sport = Enums.Sport.Football
                },
                new Match
                {
                    ID = matchID20,
                    Description = "OSFP - PAO",
                    MatchDate = new DateTime(2023, 11, 20),
                    MatchTime = new DateTime(2023, 11, 20, 12, 0, 0),
                    TeamA = "OSFP",
                    TeamB = "PAO",
                    Sport = Enums.Sport.Basketball,
                }
            );
            #endregion

            #region Match Odds
            modelBuilder.Entity<MatchOdds>().HasData(
                // Match Odds for Match 01
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 1.5M,
                    MatchID = matchID01
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 3.2M,
                    MatchID = matchID01
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 2.1M,
                    MatchID = matchID01
                },
                // Match Odds for Match 02
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 2.5M,
                    MatchID = matchID02
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 11.2M,
                    MatchID = matchID02
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 4.1M,
                    MatchID = matchID02
                },
                // Match Odds for Match 03
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 21.5M,
                    MatchID = matchID03
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 14.2M,
                    MatchID = matchID03
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 10.1M,
                    MatchID = matchID03
                },
                // Match Odds for Match 04
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 3.5M,
                    MatchID = matchID04
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 6.2M,
                    MatchID = matchID04
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 5.0M,
                    MatchID = matchID04
                },
                // Match Odds for Match 05
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 9.5M,
                    MatchID = matchID05
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 12.0M,
                    MatchID = matchID05
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 15.0M,
                    MatchID = matchID05
                },
                // Match Odds for Match 06
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 4.5M,
                    MatchID = matchID06
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 2.8M,
                    MatchID = matchID06
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 1.9M,
                    MatchID = matchID06
                },
                // Match Odds for Match 07
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 3.5M,
                    MatchID = matchID07
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 4.2M,
                    MatchID = matchID07
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 2.1M,
                    MatchID = matchID07
                },
                // Match Odds for Match 08
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 2.3M,
                    MatchID = matchID08
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 5.7M,
                    MatchID = matchID08
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 3.2M,
                    MatchID = matchID08
                },
                // Match Odds for Match 09
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 1.8M,
                    MatchID = matchID09
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 2.2M,
                    MatchID = matchID09
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 3.5M,
                    MatchID = matchID09
                },
                // Match Odds for Match 10
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 2.1M,
                    MatchID = matchID10
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 6.2M,
                    MatchID = matchID10
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 4.3M,
                    MatchID = matchID10
                },
                // Match Odds for Match 11
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 3.5M,
                    MatchID = matchID11
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 7.1M,
                    MatchID = matchID11
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 2.9M,
                    MatchID = matchID11
                },
                // Match Odds for Match 12
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 1.9M,
                    MatchID = matchID12
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 4.3M,
                    MatchID = matchID12
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 2.5M,
                    MatchID = matchID12
                },
                // Match Odds for Match 13
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 2.5M,
                    MatchID = matchID13
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 1.8M,
                    MatchID = matchID13
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 4.0M,
                    MatchID = matchID13
                },
                // Match Odds for Match 14
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 3.2M,
                    MatchID = matchID14
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 2.1M,
                    MatchID = matchID14
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 1.5M,
                    MatchID = matchID14
                },
                // Match Odds for Match 15
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 2.8M,
                    MatchID = matchID15
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 1.9M,
                    MatchID = matchID15
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 4.5M,
                    MatchID = matchID15
                },
                // Match Odds for Match 16
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 4.2M,
                    MatchID = matchID16
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 2.1M,
                    MatchID = matchID16
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 3.5M,
                    MatchID = matchID16
                },
                // Match Odds for Match 17
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 5.7M,
                    MatchID = matchID17
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 3.2M,
                    MatchID = matchID17
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 2.3M,
                    MatchID = matchID17
                },
                // Match Odds for Match 18
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 2.2M,
                    MatchID = matchID18
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 3.5M,
                    MatchID = matchID18
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 1.8M,
                    MatchID = matchID18
                },
                // Match Odds for Match 19
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 6.2M,
                    MatchID = matchID19
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 4.3M,
                    MatchID = matchID19
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 2.1M,
                    MatchID = matchID19
                },
                // Match Odds for Match 20
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.One,
                    Odd = 7.1M,
                    MatchID = matchID20
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.X,
                    Odd = 2.9M,
                    MatchID = matchID20
                },
                new MatchOdds
                {
                    ID = Guid.NewGuid(),
                    Specifier = Enums.OddSpecifier.Two,
                    Odd = 3.5M,
                    MatchID = matchID20
                }
            );
            #endregion
        }
    }
}