using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_customs_offices_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_customs_offices_200_ok(float? alliance_tax_rate, bool allow_access_with_standings, bool allow_alliance_access, float? bad_standing_tax_rate, float? corporation_tax_rate, float? excellent_standing_tax_rate, float? good_standing_tax_rate, float? neutral_standing_tax_rate, long office_id, int reinforce_exit_end, int reinforce_exit_start, Get_corporations_corporation_id_customs_offices_200_okStanding_level? standing_level, int system_id, float? terrible_standing_tax_rate)

    {
        Alliance_tax_rate = alliance_tax_rate;

        Allow_access_with_standings = allow_access_with_standings;

        Allow_alliance_access = allow_alliance_access;

        Bad_standing_tax_rate = bad_standing_tax_rate;

        Corporation_tax_rate = corporation_tax_rate;

        Excellent_standing_tax_rate = excellent_standing_tax_rate;

        Good_standing_tax_rate = good_standing_tax_rate;

        Neutral_standing_tax_rate = neutral_standing_tax_rate;

        Office_id = office_id;

        Reinforce_exit_end = reinforce_exit_end;

        Reinforce_exit_start = reinforce_exit_start;

        Standing_level = standing_level;

        System_id = system_id;

        Terrible_standing_tax_rate = terrible_standing_tax_rate;
    }

    /// <summary>
    ///     Only present if alliance access is allowed
    /// </summary>

    [JsonPropertyName("alliance_tax_rate")]
    public float? Alliance_tax_rate { get; init; }

    /// <summary>
    ///     standing_level and any standing related tax rate only present when this is true
    /// </summary>

    [JsonPropertyName("allow_access_with_standings")]
    public bool Allow_access_with_standings { get; init; }

    /// <summary>
    ///     allow_alliance_access boolean
    /// </summary>

    [JsonPropertyName("allow_alliance_access")]
    public bool Allow_alliance_access { get; init; }

    /// <summary>
    ///     bad_standing_tax_rate number
    /// </summary>

    [JsonPropertyName("bad_standing_tax_rate")]
    public float? Bad_standing_tax_rate { get; init; }

    /// <summary>
    ///     corporation_tax_rate number
    /// </summary>

    [JsonPropertyName("corporation_tax_rate")]
    public float? Corporation_tax_rate { get; init; }

    /// <summary>
    ///     Tax rate for entities with excellent level of standing, only present if this level is allowed, same for all other
    ///     standing related tax rates
    /// </summary>

    [JsonPropertyName("excellent_standing_tax_rate")]
    public float? Excellent_standing_tax_rate { get; init; }

    /// <summary>
    ///     good_standing_tax_rate number
    /// </summary>

    [JsonPropertyName("good_standing_tax_rate")]
    public float? Good_standing_tax_rate { get; init; }

    /// <summary>
    ///     neutral_standing_tax_rate number
    /// </summary>

    [JsonPropertyName("neutral_standing_tax_rate")]
    public float? Neutral_standing_tax_rate { get; init; }

    /// <summary>
    ///     unique ID of this customs office
    /// </summary>

    [JsonPropertyName("office_id")]
    public long Office_id { get; init; }

    /// <summary>
    ///     reinforce_exit_end integer
    /// </summary>

    [JsonPropertyName("reinforce_exit_end")]
    public int Reinforce_exit_end { get; init; }

    /// <summary>
    ///     Together with reinforce_exit_end, marks a 2-hour period where this customs office could exit reinforcement mode
    ///     during the day after initial attack
    /// </summary>

    [JsonPropertyName("reinforce_exit_start")]
    public int Reinforce_exit_start { get; init; }

    /// <summary>
    ///     Access is allowed only for entities with this level of standing or better
    /// </summary>

    [JsonPropertyName("standing_level")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_customs_offices_200_okStanding_level? Standing_level { get; init; }

    /// <summary>
    ///     ID of the solar system this customs office is located in
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }

    /// <summary>
    ///     terrible_standing_tax_rate number
    /// </summary>

    [JsonPropertyName("terrible_standing_tax_rate")]
    public float? Terrible_standing_tax_rate { get; init; }
}