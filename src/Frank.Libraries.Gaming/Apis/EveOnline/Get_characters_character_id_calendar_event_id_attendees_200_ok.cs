using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     character_id and response of an attendee
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_calendar_event_id_attendees_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_calendar_event_id_attendees_200_ok(int? character_id, Get_characters_character_id_calendar_event_id_attendees_200_okEvent_response? event_response)

    {
        Character_id = character_id;

        Event_response = event_response;
    }

    /// <summary>
    ///     character_id integer
    /// </summary>

    [JsonPropertyName("character_id")]
    public int? Character_id { get; init; }

    /// <summary>
    ///     event_response string
    /// </summary>

    [JsonPropertyName("event_response")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_calendar_event_id_attendees_200_okEvent_response? Event_response { get; init; }
}