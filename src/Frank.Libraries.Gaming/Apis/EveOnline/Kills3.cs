using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Kills3
{
    [JsonConstructor]
    public Kills3(IList<Active_total> active_total, IList<Last_week> last_week, IList<Yesterday> yesterday)

    {
        Active_total = active_total;

        Last_week = last_week;

        Yesterday = yesterday;
    }

    /// <summary>
    ///     Top 4 ranking of factions active in faction warfare by total kills. A faction is considered "active" if they have
    ///     participated in faction warfare in the past 14 days
    /// </summary>

    [JsonPropertyName("active_total")]
    public IList<Active_total> Active_total { get; init; }

    /// <summary>
    ///     Top 4 ranking of factions by kills in the past week
    /// </summary>

    [JsonPropertyName("last_week")]
    public IList<Last_week> Last_week { get; init; }

    /// <summary>
    ///     Top 4 ranking of factions by kills in the past day
    /// </summary>

    [JsonPropertyName("yesterday")]
    public IList<Yesterday> Yesterday { get; init; }
}