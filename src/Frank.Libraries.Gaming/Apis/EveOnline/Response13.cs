using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Forbidden
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response13
{
    [JsonConstructor]
    public Response13(string? error) => Error = error;

    /// <summary>
    ///     Forbidden message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}