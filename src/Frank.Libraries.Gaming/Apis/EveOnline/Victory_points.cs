using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Victory_points
{
    [JsonConstructor]
    public Victory_points(int last_week, int total, int yesterday)

    {
        Last_week = last_week;

        Total = total;

        Yesterday = yesterday;
    }

    /// <summary>
    ///     Last week's victory points gained by the given character
    /// </summary>

    [JsonPropertyName("last_week")]
    public int Last_week { get; init; }

    /// <summary>
    ///     Total victory points gained since the given character enlisted
    /// </summary>

    [JsonPropertyName("total")]
    public int Total { get; init; }

    /// <summary>
    ///     Yesterday's victory points gained by the given character
    /// </summary>

    [JsonPropertyName("yesterday")]
    public int Yesterday { get; init; }
}