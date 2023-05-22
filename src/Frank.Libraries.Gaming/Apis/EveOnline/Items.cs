using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     item object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Items
{
    [JsonConstructor]
    public Items(ItemsFlag flag, int quantity, int type_id)

    {
        Flag = flag;

        Quantity = quantity;

        Type_id = type_id;
    }

    /// <summary>
    ///     Fitting location for the item. Entries placed in 'Invalid' will be discarded. If this leaves the fitting with
    ///     nothing, it will cause an error.
    /// </summary>

    [JsonPropertyName("flag")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ItemsFlag Flag { get; init; }

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