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
        public DbSet<MatchOdds> MatchOdds {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbInitializer.SeedData(modelBuilder);
        }
    }
}