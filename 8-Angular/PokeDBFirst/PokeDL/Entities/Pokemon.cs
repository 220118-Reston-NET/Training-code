using System;
using System.Collections.Generic;

namespace PokeDL.Entities
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            Teams = new HashSet<Team>();
        }

        public int PokeId { get; set; }
        public string? PokeName { get; set; }
        public int? PokeAttack { get; set; }
        public int? PokeDefense { get; set; }
        public int? PokeHealth { get; set; }
        public int? PokeSpeed { get; set; }
        public string? PokeType { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
