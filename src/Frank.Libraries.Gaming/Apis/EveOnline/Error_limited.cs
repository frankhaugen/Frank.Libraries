using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Error limited model
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Error_limited
{
    [JsonConstructor]
    public Error_limited(string error) => Error = error;

    /// <summary>
    ///     Error limited message
    /// </summary>

    [JsonPropertyName("error")]
    public string Error { get; init; }
}