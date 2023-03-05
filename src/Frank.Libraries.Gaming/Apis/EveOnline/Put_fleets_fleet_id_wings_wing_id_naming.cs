using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     naming object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Put_fleets_fleet_id_wings_wing_id_naming
{
    [JsonConstructor]
    public Put_fleets_fleet_id_wings_wing_id_naming(string name) => Name = name;

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }
}