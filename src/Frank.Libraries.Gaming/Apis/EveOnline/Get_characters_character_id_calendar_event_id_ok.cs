using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Full details of a specific event
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_calendar_event_id_ok
{
    [JsonConstructor]
    public Get_characters_character_id_calendar_event_id_ok(DateTimeOffset date, int duration, int event_id, int importance, int owner_id, string owner_name, Get_characters_character_id_calendar_event_id_okOwner_type owner_type, string response, string text, string title)

    {
        Date = date;

        Duration = duration;

        Event_id = event_id;

        Importance = importance;

        Owner_id = owner_id;

        Owner_name = owner_name;

        Owner_type = owner_type;

        Response = response;

        Text = text;

        Title = title;
    }

    /// <summary>
    ///     date string
    /// </summary>

    [JsonPropertyName("date")]
    public DateTimeOffset Date { get; init; }

    /// <summary>
    ///     Length in minutes
    /// </summary>

    [JsonPropertyName("duration")]
    public int Duration { get; init; }

    /// <summary>
    ///     event_id integer
    /// </summary>

    [JsonPropertyName("event_id")]
    public int Event_id { get; init; }

    /// <summary>
    ///     importance integer
    /// </summary>

    [JsonPropertyName("importance")]
    public int Importance { get; init; }

    /// <summary>
    ///     owner_id integer
    /// </summary>

    [JsonPropertyName("owner_id")]
    public int Owner_id { get; init; }

    /// <summary>
    ///     owner_name string
    /// </summary>

    [JsonPropertyName("owner_name")]
    public string Owner_name { get; init; }

    /// <summary>
    ///     owner_type string
    /// </summary>

    [JsonPropertyName("owner_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_calendar_event_id_okOwner_type Owner_type { get; init; }

    /// <summary>
    ///     response string
    /// </summary>

    [JsonPropertyName("response")]
    public string Response { get; init; }

    /// <summary>
    ///     text string
    /// </summary>

    [JsonPropertyName("text")]
    public string Text { get; init; }

    /// <summary>
    ///     title string
    /// </summary>

    [JsonPropertyName("title")]
    public string Title { get; init; }
}