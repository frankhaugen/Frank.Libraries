using System.Collections.Generic;
using Frank.Libraries.Gaming.Starfinder.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Models
{
    public class PowerCore
    {
        public string Name { get; set; }
        public List<Size> Sizes { get; set; }
        public int PCU { get; set; }
        public int Cost { get; set; }
    }
}