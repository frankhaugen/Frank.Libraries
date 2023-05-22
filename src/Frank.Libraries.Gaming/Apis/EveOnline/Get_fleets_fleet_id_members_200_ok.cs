using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_fleets_fleet_id_members_200_ok
{
    [JsonConstructor]
    public Get_fleets_fleet_id_members_200_ok(int character_id, DateTimeOffset join_time, Get_fleets_fleet_id_members_200_okRole role, string role_name, int ship_type_id, int solar_system_id, long squad_id, long? station_id, bool takes_fleet_warp, long wing_id)

    {
        Character_id = character_id;

        Join_time = join_time;

        Role = role;

        Role_name = role_name;

        Ship_type_id = ship_type_id;

        Solar_system_id = solar_system_id;

        Squad_id = squad_id;

        Station_id = station_id;

        Takes_fleet_warp = takes_fleet_warp;

        Wing_id = wing_id;
    }

    /// <summary>
    ///     character_id integer
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     join_time string
    /// </summary>

    [JsonPropertyName("join_time")]
    public DateTimeOffset Join_time { get; init; }

    /// <summary>
    ///     Member’s role in fleet
    /// </summary>

    [JsonPropertyName("role")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_fleets_fleet_id_members_200_okRole Role { get; init; }

    /// <summary>
    ///     Localized role names
    /// </summary>

    [JsonPropertyName("role_name")]
    public string Role_name { get; init; }

    /// <summary>
    ///     ship_type_id integer
    /// </summary>

    [JsonPropertyName("ship_type_id")]
    public int Ship_type_id { get; init; }

    /// <summary>
    ///     Solar system the member is located in
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     ID of the squad the member is in. If not applicable, will be set to -1
    /// </summary>

    [JsonPropertyName("squad_id")]
    public long Squad_id { get; init; }

    /// <summary>
    ///     Station in which the member is docked in, if applicable
    /// </summary>

    [JsonPropertyName("station_id")]
    public long? Station_id { get; init; }

    /// <summary>
    ///     Whether the member take fleet warps
    /// </summary>

    [JsonPropertyName("takes_fleet_warp")]
    public bool Takes_fleet_warp { get; init; }

    /// <summary>
    ///     ID of the wing the member is in. If not applicable, will be set to -1
    /// </summary>

    [JsonPropertyName("wing_id")]
    public long Wing_id { get; init; }
}