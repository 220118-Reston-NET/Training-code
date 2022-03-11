using System;
using System.Collections.Generic;

namespace PokeDL.Entities
{
    public partial class Ability
    {
        public int AbId { get; set; }
        public string? AbName { get; set; }
        public int? Pp { get; set; }
        public int? AbPower { get; set; }
        public int? AbAccuracy { get; set; }
        public string? AbType { get; set; }
    }
}
