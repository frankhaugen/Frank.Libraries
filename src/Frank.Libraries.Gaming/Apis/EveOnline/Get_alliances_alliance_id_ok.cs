using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_alliances_alliance_id_ok
{
    [JsonConstructor]
    public Get_alliances_alliance_id_ok(int creator_corporation_id, int creator_id, DateTimeOffset date_founded, int? executor_corporation_id, int? faction_id, string name, string ticker)

    {
        Creator_corporation_id = creator_corporation_id;

        Creator_id = creator_id;

        Date_founded = date_founded;

        Executor_corporation_id = executor_corporation_id;

        Faction_id = faction_id;

        Name = name;

        Ticker = ticker;
    }

    /// <summary>
    ///     ID of the corporation that created the alliance
    /// </summary>

    [JsonPropertyName("creator_corporation_id")]
    public int Creator_corporation_id { get; init; }

    /// <summary>
    ///     ID of the character that created the alliance
    /// </summary>

    [JsonPropertyName("creator_id")]
    public int Creator_id { get; init; }

    /// <summary>
    ///     date_founded string
    /// </summary>

    [JsonPropertyName("date_founded")]
    public DateTimeOffset Date_founded { get; init; }

    /// <summary>
    ///     the executor corporation ID, if this alliance is not closed
    /// </summary>

    [JsonPropertyName("executor_corporation_id")]
    public int? Executor_corporation_id { get; init; }

    /// <summary>
    ///     Faction ID this alliance is fighting for, if this alliance is enlisted in factional warfare
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }

    /// <summary>
    ///     the full name of the alliance
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     the short name of the alliance
    /// </summary>

    [JsonPropertyName("ticker")]
    public string Ticker { get; init; }
}