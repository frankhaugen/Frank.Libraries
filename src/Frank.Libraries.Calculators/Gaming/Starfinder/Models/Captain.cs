using System.Text.Json.Serialization;

namespace Frank.Libraries.Calculators.Gaming.Starfinder.Models
{
    public class Captain
    {
        [JsonPropertyName("countOfficers")] public string CountOfficers { get; set; }

        [JsonPropertyName("hasRole")] public bool HasRole { get; set; }

        [JsonPropertyName("skills")] public Skills Skills { get; set; }
    }
}