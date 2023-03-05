using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     422 unprocessable entity object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response59
{
    [JsonConstructor]
    public Response59(string? error) => Error = error;

    /// <summary>
    ///     error message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}