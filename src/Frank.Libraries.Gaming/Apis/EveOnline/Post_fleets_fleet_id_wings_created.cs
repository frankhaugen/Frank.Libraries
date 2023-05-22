using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     201 created object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_fleets_fleet_id_wings_created
{
    [JsonConstructor]
    public Post_fleets_fleet_id_wings_created(long wing_id) => Wing_id = wing_id;

    /// <summary>
    ///     The wing_id of the newly created wing
    /// </summary>

    [JsonPropertyName("wing_id")]
    public long Wing_id { get; init; }
}