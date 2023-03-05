using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     No image server for this datasource
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Response12
{
    [JsonConstructor]
    public Response12(string? error) => Error = error;

    /// <summary>
    ///     error message
    /// </summary>

    [JsonPropertyName("error")]
    public string? Error { get; init; }
}