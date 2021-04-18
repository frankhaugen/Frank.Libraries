using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated{ 

    public class MagicOfficer
    {
        [JsonPropertyName("countOfficers")]
        public int CountOfficers { get; set; }

        [JsonPropertyName("countOfficerCrew")]
        public int CountOfficerCrew { get; set; }

        [JsonPropertyName("hasRole")]
        public bool HasRole { get; set; }

        [JsonPropertyName("skills")]
        public Skills Skills { get; set; }
    }

}