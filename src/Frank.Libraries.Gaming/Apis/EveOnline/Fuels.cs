using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     fuel object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Fuels
{
    [JsonConstructor]
    public Fuels(int quantity, int type_id)

    {
        Quantity = quantity;

        Type_id = type_id;
    }

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