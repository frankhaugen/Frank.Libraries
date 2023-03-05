using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Kills
{
    [JsonConstructor]
    public Kills(int last_week, int total, int yesterday)

    {
        Last_week = last_week;

        Total = total;

        Yesterday = yesterday;
    }

    /// <summary>
    ///     Last week's total number of kills by a given character against enemy factions
    /// </summary>

    [JsonPropertyName("last_week")]
    public int Last_week { get; init; }

    /// <summary>
    ///     Total number of kills by a given character against enemy factions since the character enlisted
    /// </summary>

    [JsonPropertyName("total")]
    public int Total { get; init; }

    /// <summary>
    ///     Yesterday's total number of kills by a given character against enemy factions
    /// </summary>

    [JsonPropertyName("yesterday")]
    public int Yesterday { get; init; }
}