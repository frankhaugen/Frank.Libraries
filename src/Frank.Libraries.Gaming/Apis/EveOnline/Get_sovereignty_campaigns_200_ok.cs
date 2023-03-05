using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_sovereignty_campaigns_200_ok
{
    [JsonConstructor]
    public Get_sovereignty_campaigns_200_ok(float? attackers_score, int campaign_id, int constellation_id, int? defender_id, float? defender_score, Get_sovereignty_campaigns_200_okEvent_type event_type, IList<Participants>? participants, int solar_system_id, DateTimeOffset start_time, long structure_id)

    {
        Attackers_score = attackers_score;

        Campaign_id = campaign_id;

        Constellation_id = constellation_id;

        Defender_id = defender_id;

        Defender_score = defender_score;

        Event_type = event_type;

        Participants = participants;

        Solar_system_id = solar_system_id;

        Start_time = start_time;

        Structure_id = structure_id;
    }

    /// <summary>
    ///     Score for all attacking parties, only present in Defense Events.
    ///     <br />
    /// </summary>

    [JsonPropertyName("attackers_score")]
    public float? Attackers_score { get; init; }

    /// <summary>
    ///     Unique ID for this campaign.
    /// </summary>

    [JsonPropertyName("campaign_id")]
    public int Campaign_id { get; init; }

    /// <summary>
    ///     The constellation in which the campaign will take place.
    ///     <br />
    /// </summary>

    [JsonPropertyName("constellation_id")]
    public int Constellation_id { get; init; }

    /// <summary>
    ///     Defending alliance, only present in Defense Events
    ///     <br />
    /// </summary>

    [JsonPropertyName("defender_id")]
    public int? Defender_id { get; init; }

    /// <summary>
    ///     Score for the defending alliance, only present in Defense Events.
    ///     <br />
    /// </summary>

    [JsonPropertyName("defender_score")]
    public float? Defender_score { get; init; }

    /// <summary>
    ///     Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as "Defense
    ///     Events", station_freeport as "Freeport Events".
    ///     <br />
    /// </summary>

    [JsonPropertyName("event_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_sovereignty_campaigns_200_okEvent_type Event_type { get; init; }

    /// <summary>
    ///     Alliance participating and their respective scores, only present in Freeport Events.
    ///     <br />
    /// </summary>

    [JsonPropertyName("participants")]
    public IList<Participants>? Participants { get; init; }

    /// <summary>
    ///     The solar system the structure is located in.
    ///     <br />
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     Time the event is scheduled to start.
    ///     <br />
    /// </summary>

    [JsonPropertyName("start_time")]
    public DateTimeOffset Start_time { get; init; }

    /// <summary>
    ///     The structure item ID that is related to this campaign.
    ///     <br />
    /// </summary>

    [JsonPropertyName("structure_id")]
    public long Structure_id { get; init; }
}