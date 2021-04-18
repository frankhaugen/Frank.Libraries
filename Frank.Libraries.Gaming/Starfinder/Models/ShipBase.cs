using Frank.Libraries.Gaming.Starfinder.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Models
{
    public class ShipBase
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public Maneuverability Maneuverability { get; set; }
        public Frame Frame { get; set; }
        public double Tier { get; set; }
        public int HitPoints { get; set; }
        public int MaximumCrew { get; set; }
        public int MinimumCrew { get; set; }
        public int Crew { get; set; }
        public int DT { get; set; }
        public int CT { get; set; }
        public int Cost { get; set; }
    }
}