using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     graphic object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Graphics
{
    [JsonConstructor]
    public Graphics(int? color, string graphic, int layer, int part)

    {
        Color = color;

        Graphic = graphic;

        Layer = layer;

        Part = part;
    }

    /// <summary>
    ///     color integer
    /// </summary>

    [JsonPropertyName("color")]
    public int? Color { get; init; }

    /// <summary>
    ///     graphic string
    /// </summary>

    [JsonPropertyName("graphic")]
    public string Graphic { get; init; }

    /// <summary>
    ///     layer integer
    /// </summary>

    [JsonPropertyName("layer")]
    public int Layer { get; init; }

    /// <summary>
    ///     part integer
    /// </summary>

    [JsonPropertyName("part")]
    public int Part { get; init; }
}