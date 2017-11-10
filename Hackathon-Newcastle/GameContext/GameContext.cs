using Hackathon_Newcastle.Models;
using Microsoft.EntityFrameworkCore;

namespace Hackathon_Newcastle.GameContext
{
    public class GameContext : DbContext
    {
        public GameContext() 
            : base()
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Shot> Shots { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}
