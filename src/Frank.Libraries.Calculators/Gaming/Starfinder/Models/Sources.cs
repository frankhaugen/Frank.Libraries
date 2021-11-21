using System.Text.Json.Serialization;

namespace Frank.Libraries.Calculators.Gaming.Starfinder.Models
{
    public class Sources
    {
        [JsonPropertyName("pw")] public bool Pw { get; set; }

        [JsonPropertyName("som")] public bool Som { get; set; }
    }
}