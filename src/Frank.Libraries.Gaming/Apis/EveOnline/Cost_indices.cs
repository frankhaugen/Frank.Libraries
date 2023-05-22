using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     cost_indice object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Cost_indices
{
    [JsonConstructor]
    public Cost_indices(Cost_indicesActivity activity, float cost_index)

    {
        Activity = activity;

        Cost_index = cost_index;
    }

    /// <summary>
    ///     activity string
    /// </summary>

    [JsonPropertyName("activity")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Cost_indicesActivity Activity { get; init; }

    /// <summary>
    ///     cost_index number
    /// </summary>

    [JsonPropertyName("cost_index")]
    public float Cost_index { get; init; }
}