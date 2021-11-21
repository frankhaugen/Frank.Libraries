using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Related
{
    public class Desktop
    {
        [JsonPropertyName("page")] public string Page { get; set; }

        [JsonPropertyName("revisions")] public string Revisions { get; set; }

        [JsonPropertyName("edit")] public string Edit { get; set; }

        [JsonPropertyName("talk")] public string Talk { get; set; }
    }
}