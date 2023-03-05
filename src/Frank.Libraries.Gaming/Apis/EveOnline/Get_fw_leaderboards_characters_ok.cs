using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_fw_leaderboards_characters_ok
{
    [JsonConstructor]
    public Get_fw_leaderboards_characters_ok(Kills4 kills, Victory_points4 victory_points)

    {
        Kills = kills;

        Victory_points = victory_points;
    }

    /// <summary>
    ///     Top 100 rankings of pilots by number of kills from yesterday, last week and in total
    /// </summary>

    [JsonPropertyName("kills")]
    public Kills4 Kills { get; init; }

    /// <summary>
    ///     Top 100 rankings of pilots by victory points from yesterday, last week and in total
    /// </summary>

    [JsonPropertyName("victory_points")]
    public Victory_points4 Victory_points { get; init; }
}