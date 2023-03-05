using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_killmails_recent_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_killmails_recent_200_ok(string killmail_hash, int killmail_id)

    {
        Killmail_hash = killmail_hash;

        Killmail_id = killmail_id;
    }

    /// <summary>
    ///     A hash of this killmail
    /// </summary>

    [JsonPropertyName("killmail_hash")]
    public string Killmail_hash { get; init; }

    /// <summary>
    ///     ID of this killmail
    /// </summary>

    [JsonPropertyName("killmail_id")]
    public int Killmail_id { get; init; }
}