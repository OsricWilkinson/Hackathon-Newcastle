using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_Newcastle.Entities
{
    public class Game
    {
        [Key]
        public Guid GameId { get; set; }

        public string GameName { get; set; }

        public ICollection<Shot> Shots { get; set; } = new List<Shot>();

        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
