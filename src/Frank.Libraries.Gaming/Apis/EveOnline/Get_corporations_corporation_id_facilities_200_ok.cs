using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_facilities_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_facilities_200_ok(long facility_id, int system_id, int type_id)

    {
        Facility_id = facility_id;

        System_id = system_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     facility_id integer
    /// </summary>

    [JsonPropertyName("facility_id")]
    public long Facility_id { get; init; }

    /// <summary>
    ///     system_id integer
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}