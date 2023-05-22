using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_standings_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_standings_200_ok(int from_id, Get_corporations_corporation_id_standings_200_okFrom_type from_type, float standing)

    {
        From_id = from_id;

        From_type = from_type;

        Standing = standing;
    }

    /// <summary>
    ///     from_id integer
    /// </summary>

    [JsonPropertyName("from_id")]
    public int From_id { get; init; }

    /// <summary>
    ///     from_type string
    /// </summary>

    [JsonPropertyName("from_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_standings_200_okFrom_type From_type { get; init; }

    /// <summary>
    ///     standing number
    /// </summary>

    [JsonPropertyName("standing")]
    public float Standing { get; init; }
}