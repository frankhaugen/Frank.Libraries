using System.Text.Json.Serialization; 
namespace Frank.Libraries.Calculators.Gaming.Starfinder.Models{ 

    public class ShieldsByPosition
    {
        [JsonPropertyName("forward")]
        public int Forward { get; set; }

        [JsonPropertyName("aft")]
        public int Aft { get; set; }

        [JsonPropertyName("port")]
        public int Port { get; set; }

        [JsonPropertyName("starboard")]
        public int Starboard { get; set; }
    }

}