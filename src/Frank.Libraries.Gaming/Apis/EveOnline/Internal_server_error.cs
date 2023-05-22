using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Internal server error model
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Internal_server_error
{
    [JsonConstructor]
    public Internal_server_error(string error) => Error = error;

    /// <summary>
    ///     Internal server error message
    /// </summary>

    [JsonPropertyName("error")]
    public string Error { get; init; }
}