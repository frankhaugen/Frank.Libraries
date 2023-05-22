using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_factions_200_ok
{
    [JsonConstructor]
    public Get_universe_factions_200_ok(int? corporation_id, string description, int faction_id, bool is_unique, int? militia_corporation_id, string name, float size_factor, int? solar_system_id, int station_count, int station_system_count)

    {
        Corporation_id = corporation_id;

        Description = description;

        Faction_id = faction_id;

        Is_unique = is_unique;

        Militia_corporation_id = militia_corporation_id;

        Name = name;

        Size_factor = size_factor;

        Solar_system_id = solar_system_id;

        Station_count = station_count;

        Station_system_count = station_system_count;
    }

    /// <summary>
    ///     corporation_id integer
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int? Corporation_id { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     faction_id integer
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int Faction_id { get; init; }

    /// <summary>
    ///     is_unique boolean
    /// </summary>

    [JsonPropertyName("is_unique")]
    public bool Is_unique { get; init; }

    /// <summary>
    ///     militia_corporation_id integer
    /// </summary>

    [JsonPropertyName("militia_corporation_id")]
    public int? Militia_corporation_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     size_factor number
    /// </summary>

    [JsonPropertyName("size_factor")]
    public float Size_factor { get; init; }

    /// <summary>
    ///     solar_system_id integer
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int? Solar_system_id { get; init; }

    /// <summary>
    ///     station_count integer
    /// </summary>

    [JsonPropertyName("station_count")]
    public int Station_count { get; init; }

    /// <summary>
    ///     station_system_count integer
    /// </summary>

    [JsonPropertyName("station_system_count")]
    public int Station_system_count { get; init; }
}