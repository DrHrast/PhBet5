using Microsoft.EntityFrameworkCore;
using PhBet5.Models;

namespace PhBet5
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<UserModel> Users { get; set; }

        public DbSet<BetsModel> Bets { get; set; }

        public DbSet<UserBettingModel> Betting { get; set; }

        public DbSet<GameScoreModel> GameScore { get; set; }
    }
}
