using Frank.Libraries.Gaming.Starfinder.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Models
{
    public class Thruster
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public int Speed { get; set; }
        public int PilotingModifier { get; set; }
        public int PCU { get; set; }
        public int Cost { get; set; }
    }
}