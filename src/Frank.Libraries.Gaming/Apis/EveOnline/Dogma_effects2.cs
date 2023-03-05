using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     dogma_effect object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Dogma_effects2
{
    [JsonConstructor]
    public Dogma_effects2(int effect_id, bool is_default)

    {
        Effect_id = effect_id;

        Is_default = is_default;
    }

    /// <summary>
    ///     effect_id integer
    /// </summary>

    [JsonPropertyName("effect_id")]
    public int Effect_id { get; init; }

    /// <summary>
    ///     is_default boolean
    /// </summary>

    [JsonPropertyName("is_default")]
    public bool Is_default { get; init; }
}