using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Service unavailable model
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Service_unavailable
{
    [JsonConstructor]
    public Service_unavailable(string error) => Error = error;

    /// <summary>
    ///     Service unavailable message
    /// </summary>

    [JsonPropertyName("error")]
    public string Error { get; init; }
}