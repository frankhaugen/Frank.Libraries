using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     movement object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Put_fleets_fleet_id_members_member_id_movement
{
    [JsonConstructor]
    public Put_fleets_fleet_id_members_member_id_movement(Put_fleets_fleet_id_members_member_id_movementRole role, long? squad_id, long? wing_id)

    {
        Role = role;

        Squad_id = squad_id;

        Wing_id = wing_id;
    }

    /// <summary>
    ///     If a character is moved to the `fleet_commander` role, neither `wing_id` or `squad_id` should be specified. If a
    ///     character is moved to the `wing_commander` role, only `wing_id` should be specified. If a character is moved to the
    ///     `squad_commander` role, both `wing_id` and `squad_id` should be specified. If a character is moved to the
    ///     `squad_member` role, both `wing_id` and `squad_id` should be specified.
    /// </summary>

    [JsonPropertyName("role")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Put_fleets_fleet_id_members_member_id_movementRole Role { get; init; }

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