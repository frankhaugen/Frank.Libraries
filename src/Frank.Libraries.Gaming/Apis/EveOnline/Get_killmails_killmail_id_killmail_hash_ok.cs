using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_killmails_killmail_id_killmail_hash_ok
{
    [JsonConstructor]
    public Get_killmails_killmail_id_killmail_hash_ok(IList<Attackers> attackers, int killmail_id, DateTimeOffset killmail_time, int? moon_id, int solar_system_id, Victim victim, int? war_id)

    {
        Attackers = attackers;

        Killmail_id = killmail_id;

        Killmail_time = killmail_time;

        Moon_id = moon_id;

        Solar_system_id = solar_system_id;

        Victim = victim;

        War_id = war_id;
    }

    /// <summary>
    ///     attackers array
    /// </summary>

    [JsonPropertyName("attackers")]
    public IList<Attackers> Attackers { get; init; }

    /// <summary>
    ///     ID of the killmail
    /// </summary>

    [JsonPropertyName("killmail_id")]
    public int Killmail_id { get; init; }

    /// <summary>
    ///     Time that the victim was killed and the killmail generated
    ///     <br />
    /// </summary>

    [JsonPropertyName("killmail_time")]
    public DateTimeOffset Killmail_time { get; init; }

    /// <summary>
    ///     Moon if the kill took place at one
    /// </summary>

    [JsonPropertyName("moon_id")]
    public int? Moon_id { get; init; }

    /// <summary>
    ///     Solar system that the kill took place in
    ///     <br />
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     victim object
    /// </summary>

    [JsonPropertyName("victim")]
    public Victim Victim { get; init; }

    /// <summary>
    ///     War if the killmail is generated in relation to an official war
    ///     <br />
    /// </summary>

    [JsonPropertyName("war_id")]
    public int? War_id { get; init; }
}