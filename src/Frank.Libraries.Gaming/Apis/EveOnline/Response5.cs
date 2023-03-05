using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Not found
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response5
{
    [JsonConstructor]
    public Response5(string? error) => Error = error;

    /// <summary>
    ///     Not found message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}