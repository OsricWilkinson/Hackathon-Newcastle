using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hackathon_Newcastle.Models
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
