using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_portrait_ok
{
    [JsonConstructor]
    public Get_characters_character_id_portrait_ok(string? px128x128, string? px256x256, string? px512x512, string? px64x64)

    {
        Px128x128 = px128x128;

        Px256x256 = px256x256;

        Px512x512 = px512x512;

        Px64x64 = px64x64;
    }

    /// <summary>
    ///     px128x128 string
    /// </summary>

    [JsonPropertyName("px128x128")]
    public string? Px128x128 { get; init; }

    /// <summary>
    ///     px256x256 string
    /// </summary>

    [JsonPropertyName("px256x256")]
    public string? Px256x256 { get; init; }

    /// <summary>
    ///     px512x512 string
    /// </summary>

    [JsonPropertyName("px512x512")]
    public string? Px512x512 { get; init; }

    /// <summary>
    ///     px64x64 string
    /// </summary>

    [JsonPropertyName("px64x64")]
    public string? Px64x64 { get; init; }
}