using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     item object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Items4
{
    [JsonConstructor]
    public Items4(int flag, int item_type_id, long? quantity_destroyed, long? quantity_dropped, int singleton)

    {
        Flag = flag;

        Item_type_id = item_type_id;

        Quantity_destroyed = quantity_destroyed;

        Quantity_dropped = quantity_dropped;

        Singleton = singleton;
    }

    /// <summary>
    ///     flag integer
    /// </summary>

    [JsonPropertyName("flag")]
    public int Flag { get; init; }

    /// <summary>
    ///     item_type_id integer
    /// </summary>

    [JsonPropertyName("item_type_id")]
    public int Item_type_id { get; init; }

    /// <summary>
    ///     quantity_destroyed integer
    /// </summary>

    [JsonPropertyName("quantity_destroyed")]
    public long? Quantity_destroyed { get; init; }

    /// <summary>
    ///     quantity_dropped integer
    /// </summary>

    [JsonPropertyName("quantity_dropped")]
    public long? Quantity_dropped { get; init; }

    /// <summary>
    ///     singleton integer
    /// </summary>

    [JsonPropertyName("singleton")]
    public int Singleton { get; init; }
}