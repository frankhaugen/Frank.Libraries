using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Summary
{
    public class Namespace
    {
        [JsonPropertyName("id")] public int Id { get; set; }

        [JsonPropertyName("text")] public string Text { get; set; }
    }
}