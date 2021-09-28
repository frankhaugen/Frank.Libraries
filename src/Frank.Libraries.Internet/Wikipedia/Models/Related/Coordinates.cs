using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Related
{
    public class Coordinates
    {
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }
    }
}