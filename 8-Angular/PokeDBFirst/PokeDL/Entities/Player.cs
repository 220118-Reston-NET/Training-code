using System;
using System.Collections.Generic;

namespace PokeDL.Entities
{
    public partial class Player
    {
        public Player()
        {
            Teams = new HashSet<Team>();
        }

        public int PlayerId { get; set; }
        public string? PlayerName { get; set; }
        public bool? PlayerGender { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
