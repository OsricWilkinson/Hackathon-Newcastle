using Microsoft.EntityFrameworkCore;

namespace Hackathon_Newcastle.Entities
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Shot> Shots { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}
