using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated{ 

    public class Perception
    {
        [JsonPropertyName("modifier")]
        public int Modifier { get; set; }

        [JsonPropertyName("ranks")]
        public int Ranks { get; set; }
    }

}