using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Error 520
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response55
{
    [JsonConstructor]
    public Response55(string? error) => Error = error;

    /// <summary>
    ///     Error 520 message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}