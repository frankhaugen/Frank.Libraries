using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_starbases_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_starbases_200_ok(int? moon_id, DateTimeOffset? onlined_since, DateTimeOffset? reinforced_until, long starbase_id, Get_corporations_corporation_id_starbases_200_okState? state, int system_id, int type_id, DateTimeOffset? unanchor_at)

    {
        Moon_id = moon_id;

        Onlined_since = onlined_since;

        Reinforced_until = reinforced_until;

        Starbase_id = starbase_id;

        State = state;

        System_id = system_id;

        Type_id = type_id;

        Unanchor_at = unanchor_at;
    }

    /// <summary>
    ///     The moon this starbase (POS) is anchored on, unanchored POSes do not have this information
    /// </summary>

    [JsonPropertyName("moon_id")]
    public int? Moon_id { get; init; }

    /// <summary>
    ///     When the POS onlined, for starbases (POSes) in online state
    /// </summary>

    [JsonPropertyName("onlined_since")]
    public DateTimeOffset? Onlined_since { get; init; }

    /// <summary>
    ///     When the POS will be out of reinforcement, for starbases (POSes) in reinforced state
    /// </summary>

    [JsonPropertyName("reinforced_until")]
    public DateTimeOffset? Reinforced_until { get; init; }

    /// <summary>
    ///     Unique ID for this starbase (POS)
    /// </summary>

    [JsonPropertyName("starbase_id")]
    public long Starbase_id { get; init; }

    /// <summary>
    ///     state string
    /// </summary>

    [JsonPropertyName("state")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_starbases_200_okState? State { get; init; }

    /// <summary>
    ///     The solar system this starbase (POS) is in, unanchored POSes have this information
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }

    /// <summary>
    ///     Starbase (POS) type
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }

    /// <summary>
    ///     When the POS started unanchoring, for starbases (POSes) in unanchoring state
    /// </summary>

    [JsonPropertyName("unanchor_at")]
    public DateTimeOffset? Unanchor_at { get; init; }
}