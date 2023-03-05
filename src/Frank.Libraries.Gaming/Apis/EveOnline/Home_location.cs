using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Home_location
{
    [JsonConstructor]
    public Home_location(long? location_id, Home_locationLocation_type? location_type)

    {
        Location_id = location_id;

        Location_type = location_type;
    }

    /// <summary>
    ///     location_id integer
    /// </summary>

    [JsonPropertyName("location_id")]
    public long? Location_id { get; init; }

    /// <summary>
    ///     location_type string
    /// </summary>

    [JsonPropertyName("location_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Home_locationLocation_type? Location_type { get; init; }
}