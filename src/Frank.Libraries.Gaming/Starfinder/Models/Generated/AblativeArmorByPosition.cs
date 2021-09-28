using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated{ 

    public class AblativeArmorByPosition
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