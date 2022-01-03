namespace EveOnlineApi;

    /// <summary>
    /// character_id and response of an attendee
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_calendar_event_id_attendees_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_calendar_event_id_attendees_200_ok(int? @character_id, Get_characters_character_id_calendar_event_id_attendees_200_okEvent_response? @event_response)

        {

            this.Character_id = @character_id;

            this.Event_response = @event_response;

        }    /// <summary>
        /// character_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int? Character_id { get; init; }

        /// <summary>
        /// event_response string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("event_response")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_calendar_event_id_attendees_200_okEvent_response? Event_response { get; init; }

    }
