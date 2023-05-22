using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Victory_points5
{
    [JsonConstructor]
    public Victory_points5(IList<Active_total6> active_total, IList<Last_week6> last_week, IList<Yesterday6> yesterday)

    {
        Active_total = active_total;

        Last_week = last_week;

        Yesterday = yesterday;
    }

    /// <summary>
    ///     Top 10 ranking of corporations active in faction warfare by total victory points. A corporation is considered
    ///     "active" if they have participated in faction warfare in the past 14 days
    /// </summary>

    [JsonPropertyName("active_total")]
    public IList<Active_total6> Active_total { get; init; }

    /// <summary>
    ///     Top 10 ranking of corporations by victory points in the past week
    /// </summary>

    [JsonPropertyName("last_week")]
    public IList<Last_week6> Last_week { get; init; }

    /// <summary>
    ///     Top 10 ranking of corporations by victory points in the past day
    /// </summary>

    [JsonPropertyName("yesterday")]
    public IList<Yesterday6> Yesterday { get; init; }
}