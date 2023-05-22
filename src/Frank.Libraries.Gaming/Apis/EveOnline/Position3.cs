using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Position3
{
    [JsonConstructor]
    public Position3(double x, double y, double z)

    {
        X = x;

        Y = y;

        Z = z;
    }

    /// <summary>
    ///     x number
    /// </summary>

    [JsonPropertyName("x")]
    public double X { get; init; }

    /// <summary>
    ///     y number
    /// </summary>

    [JsonPropertyName("y")]
    public double Y { get; init; }

    /// <summary>
    ///     z number
    /// </summary>

    [JsonPropertyName("z")]
    public double Z { get; init; }
}