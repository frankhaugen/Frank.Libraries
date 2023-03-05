using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Forbidden model
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Forbidden
{
    [JsonConstructor]
    public Forbidden(string error, int? sso_status)

    {
        Error = error;

        Sso_status = sso_status;
    }

    /// <summary>
    ///     Forbidden message
    /// </summary>

    [JsonPropertyName("error")]
    public string Error { get; init; }

    /// <summary>
    ///     status code received from SSO
    /// </summary>

    [JsonPropertyName("sso_status")]
    public int? Sso_status { get; init; }
}