using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Summary
{
    public class Originalimage
    {
        [JsonPropertyName("source")] public string Source { get; set; }

        [JsonPropertyName("width")] public int Width { get; set; }

        [JsonPropertyName("height")] public int Height { get; set; }
    }
}