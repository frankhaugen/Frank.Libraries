using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated{ 

    public class Sources
    {
        [JsonPropertyName("pw")]
        public bool Pw { get; set; }

        [JsonPropertyName("som")]
        public bool Som { get; set; }
    }

}