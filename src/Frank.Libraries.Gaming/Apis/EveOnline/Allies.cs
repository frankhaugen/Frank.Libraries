using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     ally object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Allies
{
    [JsonConstructor]
    public Allies(int? alliance_id, int? corporation_id)

    {
        Alliance_id = alliance_id;

        Corporation_id = corporation_id;
    }

    /// <summary>
    ///     Alliance ID if and only if this ally is an alliance
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int? Alliance_id { get; init; }

    /// <summary>
    ///     Corporation ID if and only if this ally is a corporation
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int? Corporation_id { get; init; }
}