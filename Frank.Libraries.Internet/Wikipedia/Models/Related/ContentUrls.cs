using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Related
{
    public class ContentUrls
    {
        [JsonPropertyName("desktop")]
        public Desktop Desktop { get; set; }

        [JsonPropertyName("mobile")]
        public Mobile Mobile { get; set; }
    }
}