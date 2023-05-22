using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_structures_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_structures_200_ok(int corporation_id, DateTimeOffset? fuel_expires, string? name, DateTimeOffset? next_reinforce_apply, int? next_reinforce_hour, int profile_id, int? reinforce_hour, IList<Services>? services, Get_corporations_corporation_id_structures_200_okState state, DateTimeOffset? state_timer_end, DateTimeOffset? state_timer_start, long structure_id, int system_id, int type_id, DateTimeOffset? unanchors_at)

    {
        Corporation_id = corporation_id;

        Fuel_expires = fuel_expires;

        Name = name;

        Next_reinforce_apply = next_reinforce_apply;

        Next_reinforce_hour = next_reinforce_hour;

        Profile_id = profile_id;

        Reinforce_hour = reinforce_hour;

        Services = services;

        State = state;

        State_timer_end = state_timer_end;

        State_timer_start = state_timer_start;

        Structure_id = structure_id;

        System_id = system_id;

        Type_id = type_id;

        Unanchors_at = unanchors_at;
    }

    /// <summary>
    ///     ID of the corporation that owns the structure
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int Corporation_id { get; init; }

    /// <summary>
    ///     Date on which the structure will run out of fuel
    /// </summary>

    [JsonPropertyName("fuel_expires")]
    public DateTimeOffset? Fuel_expires { get; init; }

    /// <summary>
    ///     The structure name
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    ///     The date and time when the structure's newly requested reinforcement times (e.g. next_reinforce_hour and
    ///     next_reinforce_day) will take effect
    /// </summary>

    [JsonPropertyName("next_reinforce_apply")]
    public DateTimeOffset? Next_reinforce_apply { get; init; }

    /// <summary>
    ///     The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply
    /// </summary>

    [JsonPropertyName("next_reinforce_hour")]
    public int? Next_reinforce_hour { get; init; }

    /// <summary>
    ///     The id of the ACL profile for this citadel
    /// </summary>

    [JsonPropertyName("profile_id")]
    public int Profile_id { get; init; }

    /// <summary>
    ///     The hour of day that determines the four hour window when the structure will randomly exit its reinforcement
    ///     periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a
    ///     random time that is +/- 2 hours centered on the value of this property
    /// </summary>

    [JsonPropertyName("reinforce_hour")]
    public int? Reinforce_hour { get; init; }

    /// <summary>
    ///     Contains a list of service upgrades, and their state
    /// </summary>

    [JsonPropertyName("services")]
    public IList<Services>? Services { get; init; }

    /// <summary>
    ///     state string
    /// </summary>

    [JsonPropertyName("state")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_structures_200_okState State { get; init; }

    /// <summary>
    ///     Date at which the structure will move to it's next state
    /// </summary>

    [JsonPropertyName("state_timer_end")]
    public DateTimeOffset? State_timer_end { get; init; }

    /// <summary>
    ///     Date at which the structure entered it's current state
    /// </summary>

    [JsonPropertyName("state_timer_start")]
    public DateTimeOffset? State_timer_start { get; init; }

    /// <summary>
    ///     The Item ID of the structure
    /// </summary>

    [JsonPropertyName("structure_id")]
    public long Structure_id { get; init; }

    /// <summary>
    ///     The solar system the structure is in
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }

    /// <summary>
    ///     The type id of the structure
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }

    /// <summary>
    ///     Date at which the structure will unanchor
    /// </summary>

    [JsonPropertyName("unanchors_at")]
    public DateTimeOffset? Unanchors_at { get; init; }
}