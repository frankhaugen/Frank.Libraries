namespace EveOnlineApi;

    /// <summary>
    /// event
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_calendar_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_calendar_200_ok(System.DateTimeOffset? @event_date, int? @event_id, Get_characters_character_id_calendar_200_okEvent_response? @event_response, int? @importance, string? @title)

        {

            this.Event_date = @event_date;

            this.Event_id = @event_id;

            this.Event_response = @event_response;

            this.Importance = @importance;

            this.Title = @title;

        }    /// <summary>
        /// event_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("event_date")]
        public System.DateTimeOffset? Event_date { get; init; }

        /// <summary>
        /// event_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public int? Event_id { get; init; }

        /// <summary>
        /// event_response string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("event_response")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_calendar_200_okEvent_response? Event_response { get; init; }

        /// <summary>
        /// importance integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("importance")]
        public int? Importance { get; init; }

        /// <summary>
        /// title string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

    }
