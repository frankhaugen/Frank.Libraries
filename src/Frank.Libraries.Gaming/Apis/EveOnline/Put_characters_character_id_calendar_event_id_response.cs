using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     response object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Put_characters_character_id_calendar_event_id_response
{
    [JsonConstructor]
    public Put_characters_character_id_calendar_event_id_response(Put_characters_character_id_calendar_event_id_responseResponse response) => Response = response;

    /// <summary>
    ///     response string
    /// </summary>

    [JsonPropertyName("response")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Put_characters_character_id_calendar_event_id_responseResponse Response { get; init; }
}