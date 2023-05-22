using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Victory_points2
{
    [JsonConstructor]
    public Victory_points2(int last_week, int total, int yesterday)

    {
        Last_week = last_week;

        Total = total;

        Yesterday = yesterday;
    }

    /// <summary>
    ///     Last week's victory points gained by members of the given corporation
    /// </summary>

    [JsonPropertyName("last_week")]
    public int Last_week { get; init; }

    /// <summary>
    ///     Total victory points gained since the given corporation enlisted
    /// </summary>

    [JsonPropertyName("total")]
    public int Total { get; init; }

    /// <summary>
    ///     Yesterday's victory points gained by members of the given corporation
    /// </summary>

    [JsonPropertyName("yesterday")]
    public int Yesterday { get; init; }
}