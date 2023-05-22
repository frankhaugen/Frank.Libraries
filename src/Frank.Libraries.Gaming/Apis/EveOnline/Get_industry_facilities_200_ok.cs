using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_industry_facilities_200_ok
{
    [JsonConstructor]
    public Get_industry_facilities_200_ok(long facility_id, int owner_id, int region_id, int solar_system_id, float? tax, int type_id)

    {
        Facility_id = facility_id;

        Owner_id = owner_id;

        Region_id = region_id;

        Solar_system_id = solar_system_id;

        Tax = tax;

        Type_id = type_id;
    }

    /// <summary>
    ///     ID of the facility
    /// </summary>

    [JsonPropertyName("facility_id")]
    public long Facility_id { get; init; }

    /// <summary>
    ///     Owner of the facility
    /// </summary>

    [JsonPropertyName("owner_id")]
    public int Owner_id { get; init; }

    /// <summary>
    ///     Region ID where the facility is
    /// </summary>

    [JsonPropertyName("region_id")]
    public int Region_id { get; init; }

    /// <summary>
    ///     Solar system ID where the facility is
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     Tax imposed by the facility
    /// </summary>

    [JsonPropertyName("tax")]
    public float? Tax { get; init; }

    /// <summary>
    ///     Type ID of the facility
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}