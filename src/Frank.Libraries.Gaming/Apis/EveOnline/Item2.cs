using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Item2
{
    [JsonConstructor]
    public Item2(long item_id, int type_id)

    {
        Item_id = item_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     item_id integer
    /// </summary>

    [JsonPropertyName("item_id")]
    public long Item_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}