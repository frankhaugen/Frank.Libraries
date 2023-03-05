using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     last_week object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Last_week
{
    [JsonConstructor]
    public Last_week(int? amount, int? faction_id)

    {
        Amount = amount;

        Faction_id = faction_id;
    }

    /// <summary>
    ///     Amount of kills
    /// </summary>

    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    ///     faction_id integer
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }
}