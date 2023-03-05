using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     level object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Levels
{
    [JsonConstructor]
    public Levels(float cost, string name, float payout)

    {
        Cost = cost;

        Name = name;

        Payout = payout;
    }

    /// <summary>
    ///     cost number
    /// </summary>

    [JsonPropertyName("cost")]
    public float Cost { get; init; }

    /// <summary>
    ///     Localized insurance level
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     payout number
    /// </summary>

    [JsonPropertyName("payout")]
    public float Payout { get; init; }
}