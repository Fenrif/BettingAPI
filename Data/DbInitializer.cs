using BettingAPI.Models;
using Microsoft.EntityFrameworkCore;
using Match = BettingAPI.Models.Match;

namespace BettingAPI.Data
{
    public class DbInitializer
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var matchID01 = Guid.NewGuid();
            var matchID02 = Guid.NewGuid();
            var matchID03 = Guid.NewGuid();


            modelBuilder.Entity<Match>().HasData(
                new Match
                {
                    ID = matchID01,
                    Description = "OSFP - PAO",
                    MatchDate = DateTime.Now.Date,
                    MatchTime = DateTime.Now,
                    TeamA = "OSFP",
                    TeamB = "PAO",
                    Sport = Enums.Sport.Football
                },
                new Match{
                    ID = matchID02,
                    Description = "OSFP - PAO",
                    MatchDate = DateTime.Now.Date,
                    MatchTime = DateTime.Now,
                    TeamA = "OSFP",
                    TeamB = "PAO",
                    Sport = Enums.Sport.Basketball,
                },
                new Match{
                    ID = matchID03,
                    Description = "AEK - ARIS",
                    MatchDate = DateTime.Now.Date,
                    MatchTime = DateTime.Now,
                    TeamA = "AEK",
                    TeamB = "ARIS",
                    Sport = Enums.Sport.Basketball
                }
            );

            modelBuilder.Entity<MatchOdds>().HasData(
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
                        }
            );
        }
    }
}