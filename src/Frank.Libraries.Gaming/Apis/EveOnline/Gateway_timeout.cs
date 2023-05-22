using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Gateway timeout model
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Gateway_timeout
{
    [JsonConstructor]
    public Gateway_timeout(string error, int? timeout)

    {
        Error = error;

        Timeout = timeout;
    }

    /// <summary>
    ///     Gateway timeout message
    /// </summary>

    [JsonPropertyName("error")]
    public string Error { get; init; }

    /// <summary>
    ///     number of seconds the request was given
    /// </summary>

    [JsonPropertyName("timeout")]
    public int? Timeout { get; init; }
}