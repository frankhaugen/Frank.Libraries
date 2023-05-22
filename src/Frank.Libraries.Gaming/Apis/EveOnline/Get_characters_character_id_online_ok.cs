using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_online_ok
{
    [JsonConstructor]
    public Get_characters_character_id_online_ok(DateTimeOffset? last_login, DateTimeOffset? last_logout, int? logins, bool online)

    {
        Last_login = last_login;

        Last_logout = last_logout;

        Logins = logins;

        Online = online;
    }

    /// <summary>
    ///     Timestamp of the last login
    /// </summary>

    [JsonPropertyName("last_login")]
    public DateTimeOffset? Last_login { get; init; }

    /// <summary>
    ///     Timestamp of the last logout
    /// </summary>

    [JsonPropertyName("last_logout")]
    public DateTimeOffset? Last_logout { get; init; }

    /// <summary>
    ///     Total number of times the character has logged in
    /// </summary>

    [JsonPropertyName("logins")]
    public int? Logins { get; init; }

    /// <summary>
    ///     If the character is online
    /// </summary>

    [JsonPropertyName("online")]
    public bool Online { get; init; }
}