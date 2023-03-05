using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_incursions_200_ok
{
    [JsonConstructor]
    public Get_incursions_200_ok(int constellation_id, int faction_id, bool has_boss, IList<int> infested_solar_systems, float influence, int staging_solar_system_id, Get_incursions_200_okState state, string type)

    {
        Constellation_id = constellation_id;

        Faction_id = faction_id;

        Has_boss = has_boss;

        Infested_solar_systems = infested_solar_systems;

        Influence = influence;

        Staging_solar_system_id = staging_solar_system_id;

        State = state;

        Type = type;
    }

    /// <summary>
    ///     The constellation id in which this incursion takes place
    /// </summary>

    [JsonPropertyName("constellation_id")]
    public int Constellation_id { get; init; }

    /// <summary>
    ///     The attacking faction's id
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int Faction_id { get; init; }

    /// <summary>
    ///     Whether the final encounter has boss or not
    /// </summary>

    [JsonPropertyName("has_boss")]
    public bool Has_boss { get; init; }

    /// <summary>
    ///     A list of infested solar system ids that are a part of this incursion
    /// </summary>

    [JsonPropertyName("infested_solar_systems")]
    public IList<int> Infested_solar_systems { get; init; }

    /// <summary>
    ///     Influence of this incursion as a float from 0 to 1
    /// </summary>

    [JsonPropertyName("influence")]
    public float Influence { get; init; }

    /// <summary>
    ///     Staging solar system for this incursion
    /// </summary>

    [JsonPropertyName("staging_solar_system_id")]
    public int Staging_solar_system_id { get; init; }

    /// <summary>
    ///     The state of this incursion
    /// </summary>

    [JsonPropertyName("state")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_incursions_200_okState State { get; init; }

    /// <summary>
    ///     The type of this incursion
    /// </summary>

    [JsonPropertyName("type")]
    public string Type { get; init; }
}