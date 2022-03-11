using System;
using System.Collections.Generic;

namespace PokeDL.Entities
{
    public partial class Arsenal
    {
        public int? TeamId { get; set; }
        public int? AbId { get; set; }
        public int? CurrentPp { get; set; }

        public virtual Ability? Ab { get; set; }
        public virtual Team? Team { get; set; }
    }
}
