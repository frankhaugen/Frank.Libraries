using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Summary
{
    public class Titles
    {
        [JsonPropertyName("canonical")] public string Canonical { get; set; }

        [JsonPropertyName("normalized")] public string Normalized { get; set; }

        [JsonPropertyName("display")] public string Display { get; set; }
    }
}