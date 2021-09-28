using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Related
{
    public class Thumbnail
    {
        [JsonPropertyName("source")] public string Source { get; set; }

        [JsonPropertyName("width")] public int Width { get; set; }

        [JsonPropertyName("height")] public int Height { get; set; }
    }
}