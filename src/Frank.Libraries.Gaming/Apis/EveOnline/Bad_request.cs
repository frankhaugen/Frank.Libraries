using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Bad request model
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Bad_request
{
    [JsonConstructor]
    public Bad_request(string error) => Error = error;

    /// <summary>
    ///     Bad request message
    /// </summary>

    [JsonPropertyName("error")]
    public string Error { get; init; }
}