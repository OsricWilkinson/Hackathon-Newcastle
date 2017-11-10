using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_Newcastle.Models
{
    public class Player
    {
        [Key]
        public Guid PlayerId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name too Long")]
        public string Name { get; set; }

        [Required]
        [ForeignKey(nameof(Game))]
        public Guid GameId {get; set;}

        public virtual Game Game { get; set; }

        public virtual ICollection<Ship> Ships { get; set; } = new List<Ship>();

    }
}
