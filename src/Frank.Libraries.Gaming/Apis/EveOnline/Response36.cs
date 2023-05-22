using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Unprocessable entity
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response36
{
    [JsonConstructor]
    public Response36(string? error) => Error = error;

    /// <summary>
    ///     Unprocessable entity message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}