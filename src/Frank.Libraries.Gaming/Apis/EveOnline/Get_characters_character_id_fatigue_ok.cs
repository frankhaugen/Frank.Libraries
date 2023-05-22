using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_fatigue_ok
{
    [JsonConstructor]
    public Get_characters_character_id_fatigue_ok(DateTimeOffset? jump_fatigue_expire_date, DateTimeOffset? last_jump_date, DateTimeOffset? last_update_date)

    {
        Jump_fatigue_expire_date = jump_fatigue_expire_date;

        Last_jump_date = last_jump_date;

        Last_update_date = last_update_date;
    }

    /// <summary>
    ///     Character's jump fatigue expiry
    /// </summary>

    [JsonPropertyName("jump_fatigue_expire_date")]
    public DateTimeOffset? Jump_fatigue_expire_date { get; init; }

    /// <summary>
    ///     Character's last jump activation
    /// </summary>

    [JsonPropertyName("last_jump_date")]
    public DateTimeOffset? Last_jump_date { get; init; }

    /// <summary>
    ///     Character's last jump update
    /// </summary>

    [JsonPropertyName("last_update_date")]
    public DateTimeOffset? Last_update_date { get; init; }
}