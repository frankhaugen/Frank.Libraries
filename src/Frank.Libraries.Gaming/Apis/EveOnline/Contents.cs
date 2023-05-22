using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     content object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Contents
{
    [JsonConstructor]
    public Contents(long amount, int type_id)

    {
        Amount = amount;

        Type_id = type_id;
    }

    /// <summary>
    ///     amount integer
    /// </summary>

    [JsonPropertyName("amount")]
    public long Amount { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}