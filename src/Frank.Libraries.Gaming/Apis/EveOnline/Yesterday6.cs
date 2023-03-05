using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     yesterday object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Yesterday6
{
    [JsonConstructor]
    public Yesterday6(int? amount, int? corporation_id)

    {
        Amount = amount;

        Corporation_id = corporation_id;
    }

    /// <summary>
    ///     Amount of victory points
    /// </summary>

    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    ///     corporation_id integer
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int? Corporation_id { get; init; }
}