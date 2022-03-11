using System;
using System.Collections.Generic;

namespace PokeDL.Entities
{
    public partial class Team
    {
        public int TeamId { get; set; }
        public int? PokeLevel { get; set; }
        public int? PlayerId { get; set; }
        public int? PokeId { get; set; }
        public int? CurrentHealth { get; set; }

        public virtual Player? Player { get; set; }
        public virtual Pokemon? Poke { get; set; }
    }
}
