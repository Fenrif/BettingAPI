using BettingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<Match> Match {get; set;}
        //=> Set<Match>();
        public DbSet<MatchOdds> MatchOdds {get; set;}
    }
}