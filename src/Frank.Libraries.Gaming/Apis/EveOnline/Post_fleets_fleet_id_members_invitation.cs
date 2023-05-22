using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     invitation object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_fleets_fleet_id_members_invitation
{
    [JsonConstructor]
    public Post_fleets_fleet_id_members_invitation(int character_id, Post_fleets_fleet_id_members_invitationRole role, long? squad_id, long? wing_id)

    {
        Character_id = character_id;

        Role = role;

        Squad_id = squad_id;

        Wing_id = wing_id;
    }

    /// <summary>
    ///     The character you want to invite
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     If a character is invited with the `fleet_commander` role, neither `wing_id` or `squad_id` should be specified. If
    ///     a character is invited with the `wing_commander` role, only `wing_id` should be specified. If a character is
    ///     invited with the `squad_commander` role, both `wing_id` and `squad_id` should be specified. If a character is
    ///     invited with the `squad_member` role, `wing_id` and `squad_id` should either both be specified or not specified at
    ///     all. If they aren’t specified, the invited character will join any squad with available positions.
    /// </summary>

    [JsonPropertyName("role")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Post_fleets_fleet_id_members_invitationRole Role { get; init; }

    /// <summary>
    ///     squad_id integer
    /// </summary>

    [JsonPropertyName("squad_id")]
    public long? Squad_id { get; init; }

    /// <summary>
    ///     wing_id integer
    /// </summary>

    [JsonPropertyName("wing_id")]
    public long? Wing_id { get; init; }
}