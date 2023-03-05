using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Requested page does not exist
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response4
{
    [JsonConstructor]
    public Response4(string? error) => Error = error;

    /// <summary>
    ///     error message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}