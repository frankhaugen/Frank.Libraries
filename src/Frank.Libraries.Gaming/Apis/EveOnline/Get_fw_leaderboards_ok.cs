using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_fw_leaderboards_ok
{
    [JsonConstructor]
    public Get_fw_leaderboards_ok(Kills3 kills, Victory_points3 victory_points)

    {
        Kills = kills;

        Victory_points = victory_points;
    }

    /// <summary>
    ///     Top 4 rankings of factions by number of kills from yesterday, last week and in total
    /// </summary>

    [JsonPropertyName("kills")]
    public Kills3 Kills { get; init; }

    /// <summary>
    ///     Top 4 rankings of factions by victory points from yesterday, last week and in total
    /// </summary>

    [JsonPropertyName("victory_points")]
    public Victory_points3 Victory_points { get; init; }
}