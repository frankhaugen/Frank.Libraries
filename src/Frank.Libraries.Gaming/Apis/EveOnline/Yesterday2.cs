using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     yesterday object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Yesterday2
{
    [JsonConstructor]
    public Yesterday2(int? amount, int? faction_id)

    {
        Amount = amount;

        Faction_id = faction_id;
    }

    /// <summary>
    ///     Amount of victory points
    /// </summary>

    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    ///     faction_id integer
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }
}