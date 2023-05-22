using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_fw_stats_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_fw_stats_ok(DateTimeOffset? enlisted_on, int? faction_id, Kills2 kills, int? pilots, Victory_points2 victory_points)

    {
        Enlisted_on = enlisted_on;

        Faction_id = faction_id;

        Kills = kills;

        Pilots = pilots;

        Victory_points = victory_points;
    }

    /// <summary>
    ///     The enlistment date of the given corporation into faction warfare. Will not be included if corporation is not
    ///     enlisted in faction warfare
    /// </summary>

    [JsonPropertyName("enlisted_on")]
    public DateTimeOffset? Enlisted_on { get; init; }

    /// <summary>
    ///     The faction the given corporation is enlisted to fight for. Will not be included if corporation is not enlisted in
    ///     faction warfare
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }

    /// <summary>
    ///     Summary of kills done by the given corporation against enemy factions
    /// </summary>

    [JsonPropertyName("kills")]
    public Kills2 Kills { get; init; }

    /// <summary>
    ///     How many pilots the enlisted corporation has. Will not be included if corporation is not enlisted in faction
    ///     warfare
    /// </summary>

    [JsonPropertyName("pilots")]
    public int? Pilots { get; init; }

    /// <summary>
    ///     Summary of victory points gained by the given corporation for the enlisted faction
    /// </summary>

    [JsonPropertyName("victory_points")]
    public Victory_points2 Victory_points { get; init; }
}