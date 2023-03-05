using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     dogma_attribute object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Dogma_attributes
{
    [JsonConstructor]
    public Dogma_attributes(int attribute_id, float value)

    {
        Attribute_id = attribute_id;

        Value = value;
    }

    /// <summary>
    ///     attribute_id integer
    /// </summary>

    [JsonPropertyName("attribute_id")]
    public int Attribute_id { get; init; }

    /// <summary>
    ///     value number
    /// </summary>

    [JsonPropertyName("value")]
    public float Value { get; init; }
}