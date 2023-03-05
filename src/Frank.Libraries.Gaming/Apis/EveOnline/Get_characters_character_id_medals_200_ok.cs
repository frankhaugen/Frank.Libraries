using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_medals_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_medals_200_ok(int corporation_id, DateTimeOffset date, string description, IList<Graphics> graphics, int issuer_id, int medal_id, string reason, Get_characters_character_id_medals_200_okStatus status, string title)

    {
        Corporation_id = corporation_id;

        Date = date;

        Description = description;

        Graphics = graphics;

        Issuer_id = issuer_id;

        Medal_id = medal_id;

        Reason = reason;

        Status = status;

        Title = title;
    }

    /// <summary>
    ///     corporation_id integer
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int Corporation_id { get; init; }

    /// <summary>
    ///     date string
    /// </summary>

    [JsonPropertyName("date")]
    public DateTimeOffset Date { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     graphics array
    /// </summary>

    [JsonPropertyName("graphics")]
    public IList<Graphics> Graphics { get; init; }

    /// <summary>
    ///     issuer_id integer
    /// </summary>

    [JsonPropertyName("issuer_id")]
    public int Issuer_id { get; init; }

    /// <summary>
    ///     medal_id integer
    /// </summary>

    [JsonPropertyName("medal_id")]
    public int Medal_id { get; init; }

    /// <summary>
    ///     reason string
    /// </summary>

    [JsonPropertyName("reason")]
    public string Reason { get; init; }

    /// <summary>
    ///     status string
    /// </summary>

    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_medals_200_okStatus Status { get; init; }

    /// <summary>
    ///     title string
    /// </summary>

    [JsonPropertyName("title")]
    public string Title { get; init; }
}