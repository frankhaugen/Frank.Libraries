namespace EveOnlineApi;

    /// <summary>
    /// response object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Put_characters_character_id_calendar_event_id_response
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Put_characters_character_id_calendar_event_id_response(Put_characters_character_id_calendar_event_id_responseResponse @response)

        {

            this.Response = @response;

        }    /// <summary>
        /// response string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("response")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Put_characters_character_id_calendar_event_id_responseResponse Response { get; init; }

    }
