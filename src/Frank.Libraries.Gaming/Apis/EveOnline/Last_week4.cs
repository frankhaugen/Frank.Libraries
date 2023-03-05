using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     last_week object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Last_week4
{
    [JsonConstructor]
    public Last_week4(int? amount, int? character_id)

    {
        Amount = amount;

        Character_id = character_id;
    }

    /// <summary>
    ///     Amount of victory points
    /// </summary>

    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    ///     character_id integer
    /// </summary>

    [JsonPropertyName("character_id")]
    public int? Character_id { get; init; }
}