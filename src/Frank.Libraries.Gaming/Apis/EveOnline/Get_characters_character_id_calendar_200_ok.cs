using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     event
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_calendar_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_calendar_200_ok(DateTimeOffset? event_date, int? event_id, Get_characters_character_id_calendar_200_okEvent_response? event_response, int? importance, string? title)

    {
        Event_date = event_date;

        Event_id = event_id;

        Event_response = event_response;

        Importance = importance;

        Title = title;
    }

    /// <summary>
    ///     event_date string
    /// </summary>

    [JsonPropertyName("event_date")]
    public DateTimeOffset? Event_date { get; init; }

    /// <summary>
    ///     event_id integer
    /// </summary>

    [JsonPropertyName("event_id")]
    public int? Event_id { get; init; }

    /// <summary>
    ///     event_response string
    /// </summary>

    [JsonPropertyName("event_response")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_calendar_200_okEvent_response? Event_response { get; init; }

    /// <summary>
    ///     importance integer
    /// </summary>

    [JsonPropertyName("importance")]
    public int? Importance { get; init; }

    /// <summary>
    ///     title string
    /// </summary>

    [JsonPropertyName("title")]
    public string? Title { get; init; }
}