using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Extractor_details
{
    [JsonConstructor]
    public Extractor_details(int? cycle_time, float? head_radius, IList<Heads> heads, int? product_type_id, int? qty_per_cycle)

    {
        Cycle_time = cycle_time;

        Head_radius = head_radius;

        Heads = heads;

        Product_type_id = product_type_id;

        Qty_per_cycle = qty_per_cycle;
    }

    /// <summary>
    ///     in seconds
    /// </summary>

    [JsonPropertyName("cycle_time")]
    public int? Cycle_time { get; init; }

    /// <summary>
    ///     head_radius number
    /// </summary>

    [JsonPropertyName("head_radius")]
    public float? Head_radius { get; init; }

    /// <summary>
    ///     heads array
    /// </summary>

    [JsonPropertyName("heads")]
    public IList<Heads> Heads { get; init; }

    /// <summary>
    ///     product_type_id integer
    /// </summary>

    [JsonPropertyName("product_type_id")]
    public int? Product_type_id { get; init; }

    /// <summary>
    ///     qty_per_cycle integer
    /// </summary>

    [JsonPropertyName("qty_per_cycle")]
    public int? Qty_per_cycle { get; init; }
}