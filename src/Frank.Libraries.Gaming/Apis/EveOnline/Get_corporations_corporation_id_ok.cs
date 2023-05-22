using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_ok(int? alliance_id, int ceo_id, int creator_id, DateTimeOffset? date_founded, string? description, int? faction_id, int? home_station_id, int member_count, string name, long? shares, float tax_rate, string ticker, string? url, bool? war_eligible)

    {
        Alliance_id = alliance_id;

        Ceo_id = ceo_id;

        Creator_id = creator_id;

        Date_founded = date_founded;

        Description = description;

        Faction_id = faction_id;

        Home_station_id = home_station_id;

        Member_count = member_count;

        Name = name;

        Shares = shares;

        Tax_rate = tax_rate;

        Ticker = ticker;

        Url = url;

        War_eligible = war_eligible;
    }

    /// <summary>
    ///     ID of the alliance that corporation is a member of, if any
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int? Alliance_id { get; init; }

    /// <summary>
    ///     ceo_id integer
    /// </summary>

    [JsonPropertyName("ceo_id")]
    public int Ceo_id { get; init; }

    /// <summary>
    ///     creator_id integer
    /// </summary>

    [JsonPropertyName("creator_id")]
    public int Creator_id { get; init; }

    /// <summary>
    ///     date_founded string
    /// </summary>

    [JsonPropertyName("date_founded")]
    public DateTimeOffset? Date_founded { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    ///     faction_id integer
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }

    /// <summary>
    ///     home_station_id integer
    /// </summary>

    [JsonPropertyName("home_station_id")]
    public int? Home_station_id { get; init; }

    /// <summary>
    ///     member_count integer
    /// </summary>

    [JsonPropertyName("member_count")]
    public int Member_count { get; init; }

    /// <summary>
    ///     the full name of the corporation
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     shares integer
    /// </summary>

    [JsonPropertyName("shares")]
    public long? Shares { get; init; }

    /// <summary>
    ///     tax_rate number
    /// </summary>

    [JsonPropertyName("tax_rate")]
    public float Tax_rate { get; init; }

    /// <summary>
    ///     the short name of the corporation
    /// </summary>

    [JsonPropertyName("ticker")]
    public string Ticker { get; init; }

    /// <summary>
    ///     url string
    /// </summary>

    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    ///     war_eligible boolean
    /// </summary>

    [JsonPropertyName("war_eligible")]
    public bool? War_eligible { get; init; }
}