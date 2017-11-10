using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_Newcastle.Models
{
    public class Shot
    {
        [Key]
        public Guid ShotId { get; set; }

        [Required]
        public int X { get; set; }

        [Required]
        public int Y { get; set; }

        public bool IsHit { get; set; }

        [Required]
        [ForeignKey(nameof(Game))]
        public Guid GameId { get; set; }

        public Game Game { get; set; }
    }
}