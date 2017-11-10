using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackathon_Newcastle.Entities

{
    public class Ship
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public int StartX { get; set; }

        [Required]
        public int StartY { get; set; }

        [Required]
        public string Direction { get; set; }

        public bool Distroyes { get; set; }

        [Required]
        [ForeignKey(nameof(Player))]
        public Guid PlayerId { get; set; }

        public Player Player { get; set; }

        public Ship(int size)
        {
            Size = size;
        }
    }
}
