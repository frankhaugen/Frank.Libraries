using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     modifier object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Modifiers
{
    [JsonConstructor]
    public Modifiers(string? domain, int? effect_id, string func, int? modified_attribute_id, int? modifying_attribute_id, int? @operator)

    {
        Domain = domain;

        Effect_id = effect_id;

        Func = func;

        Modified_attribute_id = modified_attribute_id;

        Modifying_attribute_id = modifying_attribute_id;

        Operator = @operator;
    }

    /// <summary>
    ///     domain string
    /// </summary>

    [JsonPropertyName("domain")]
    public string? Domain { get; init; }

    /// <summary>
    ///     effect_id integer
    /// </summary>

    [JsonPropertyName("effect_id")]
    public int? Effect_id { get; init; }

    /// <summary>
    ///     func string
    /// </summary>

    [JsonPropertyName("func")]
    public string Func { get; init; }

    /// <summary>
    ///     modified_attribute_id integer
    /// </summary>

    [JsonPropertyName("modified_attribute_id")]
    public int? Modified_attribute_id { get; init; }

    /// <summary>
    ///     modifying_attribute_id integer
    /// </summary>

    [JsonPropertyName("modifying_attribute_id")]
    public int? Modifying_attribute_id { get; init; }

    /// <summary>
    ///     operator integer
    /// </summary>

    [JsonPropertyName("operator")]
    public int? Operator { get; init; }
}