using System.Text.Json.Serialization; 
namespace Frank.Libraries.Calculators.Gaming.Starfinder.Models{ 

    public class Engineering
    {
        [JsonPropertyName("modifier")]
        public int Modifier { get; set; }

        [JsonPropertyName("ranks")]
        public int Ranks { get; set; }
    }

}