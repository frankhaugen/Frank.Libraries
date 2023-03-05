using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Forbidden
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response15
{
    [JsonConstructor]
    public Response15(string? error) => Error = error;

    /// <summary>
    ///     Forbidden message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}