using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Factory_details
{
    [JsonConstructor]
    public Factory_details(int schematic_id) => Schematic_id = schematic_id;

    /// <summary>
    ///     schematic_id integer
    /// </summary>

    [JsonPropertyName("schematic_id")]
    public int Schematic_id { get; init; }
}