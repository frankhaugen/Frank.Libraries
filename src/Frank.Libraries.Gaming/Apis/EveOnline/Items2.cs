using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     item object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Items2
{
    [JsonConstructor]
    public Items2(Items2Flag flag, int quantity, int type_id)

    {
        Flag = flag;

        Quantity = quantity;

        Type_id = type_id;
    }

    /// <summary>
    ///     flag string
    /// </summary>

    [JsonPropertyName("flag")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Items2Flag Flag { get; init; }

    /// <summary>
    ///     quantity integer
    /// </summary>

    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}