using System.Text.Json.Serialization;

namespace Frank.Libraries.Calculators.Gaming.Starfinder.Models
{
    public class Skills
    {
        [JsonPropertyName("bluff")] public Bluff Bluff { get; set; }

        [JsonPropertyName("computers")] public Computers Computers { get; set; }

        [JsonPropertyName("diplomacy")] public Diplomacy Diplomacy { get; set; }

        [JsonPropertyName("engineering")] public Engineering Engineering { get; set; }

        [JsonPropertyName("gunnery")] public Gunnery Gunnery { get; set; }

        [JsonPropertyName("intimidate")] public Intimidate Intimidate { get; set; }

        [JsonPropertyName("perception")] public Perception Perception { get; set; }

        [JsonPropertyName("piloting")] public Piloting Piloting { get; set; }

        [JsonPropertyName("life-science")] public LifeScience LifeScience { get; set; }

        [JsonPropertyName("physical-science")] public PhysicalScience PhysicalScience { get; set; }

        [JsonPropertyName("acrobatics")] public Acrobatics Acrobatics { get; set; }

        [JsonPropertyName("athletics")] public Athletics Athletics { get; set; }

        [JsonPropertyName("mysticism")] public Mysticism Mysticism { get; set; }
    }
}