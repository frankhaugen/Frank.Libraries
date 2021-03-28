using System.Text.Json.Serialization; 
namespace Frank.Libraries.Calculators.Gaming.Starfinder.Models{ 

    public class Gunnery
    {
        [JsonPropertyName("modifier")]
        public int Modifier { get; set; }
    }

}