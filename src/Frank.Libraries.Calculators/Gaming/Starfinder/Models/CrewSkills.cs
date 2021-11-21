using System.Text.Json.Serialization;

namespace Frank.Libraries.Calculators.Gaming.Starfinder.Models
{
    public class CrewSkills
    {
        [JsonPropertyName("captain")] public Captain Captain { get; set; }

        [JsonPropertyName("engineer")] public Engineer Engineer { get; set; }

        [JsonPropertyName("gunner")] public Gunner Gunner { get; set; }

        [JsonPropertyName("pilot")] public Pilot Pilot { get; set; }

        [JsonPropertyName("scienceOfficer")] public ScienceOfficer ScienceOfficer { get; set; }

        [JsonPropertyName("chiefMate")] public ChiefMate ChiefMate { get; set; }

        [JsonPropertyName("magicOfficer")] public MagicOfficer MagicOfficer { get; set; }
    }
}