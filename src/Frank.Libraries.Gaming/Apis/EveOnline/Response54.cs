using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Error 520
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response54
{
    [JsonConstructor]
    public Response54(string? error) => Error = error;

    /// <summary>
    ///     Error 520 message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}