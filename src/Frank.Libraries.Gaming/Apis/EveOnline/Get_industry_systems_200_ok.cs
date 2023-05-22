using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_industry_systems_200_ok
{
    [JsonConstructor]
    public Get_industry_systems_200_ok(IList<Cost_indices> cost_indices, int solar_system_id)

    {
        Cost_indices = cost_indices;

        Solar_system_id = solar_system_id;
    }

    /// <summary>
    ///     cost_indices array
    /// </summary>

    [JsonPropertyName("cost_indices")]
    public IList<Cost_indices> Cost_indices { get; init; }

    /// <summary>
    ///     solar_system_id integer
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }
}