using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Summary
{
    public class Coordinates
    {
        [JsonPropertyName("lat")] public int Lat { get; set; }

        [JsonPropertyName("lon")] public int Lon { get; set; }
    }
}