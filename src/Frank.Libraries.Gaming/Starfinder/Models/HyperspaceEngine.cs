using Frank.Libraries.Gaming.Starfinder.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Models
{
    public class HyperspaceEngine
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public int MinPCU { get; set; }
        public Size? MaxSize { get; set; }
        public int Cost { get; set; }
    }
}