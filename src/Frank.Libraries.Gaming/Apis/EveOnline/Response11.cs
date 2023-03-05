using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Colony not found
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response11
{
    [JsonConstructor]
    public Response11(string? error) => Error = error;

    /// <summary>
    ///     error message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}