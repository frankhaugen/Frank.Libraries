using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_shareholders_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_shareholders_200_ok(long share_count, int shareholder_id, Get_corporations_corporation_id_shareholders_200_okShareholder_type shareholder_type)

    {
        Share_count = share_count;

        Shareholder_id = shareholder_id;

        Shareholder_type = shareholder_type;
    }

    /// <summary>
    ///     share_count integer
    /// </summary>

    [JsonPropertyName("share_count")]
    public long Share_count { get; init; }

    /// <summary>
    ///     shareholder_id integer
    /// </summary>

    [JsonPropertyName("shareholder_id")]
    public int Shareholder_id { get; init; }

    /// <summary>
    ///     shareholder_type string
    /// </summary>

    [JsonPropertyName("shareholder_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_shareholders_200_okShareholder_type Shareholder_type { get; init; }
}