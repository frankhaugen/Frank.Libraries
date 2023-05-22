using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     head object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Heads
{
    [JsonConstructor]
    public Heads(int head_id, float latitude, float longitude)

    {
        Head_id = head_id;

        Latitude = latitude;

        Longitude = longitude;
    }

    /// <summary>
    ///     head_id integer
    /// </summary>

    [JsonPropertyName("head_id")]
    public int Head_id { get; init; }

    /// <summary>
    ///     latitude number
    /// </summary>

    [JsonPropertyName("latitude")]
    public float Latitude { get; init; }

    /// <summary>
    ///     longitude number
    /// </summary>

    [JsonPropertyName("longitude")]
    public float Longitude { get; init; }
}