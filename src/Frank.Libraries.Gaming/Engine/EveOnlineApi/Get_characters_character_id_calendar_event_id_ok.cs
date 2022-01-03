namespace EveOnlineApi;

    /// <summary>
    /// Full details of a specific event
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_calendar_event_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_calendar_event_id_ok(System.DateTimeOffset @date, int @duration, int @event_id, int @importance, int @owner_id, string @owner_name, Get_characters_character_id_calendar_event_id_okOwner_type @owner_type, string @response, string @text, string @title)

        {

            this.Date = @date;

            this.Duration = @duration;

            this.Event_id = @event_id;

            this.Importance = @importance;

            this.Owner_id = @owner_id;

            this.Owner_name = @owner_name;

            this.Owner_type = @owner_type;

            this.Response = @response;

            this.Text = @text;

            this.Title = @title;

        }    /// <summary>
        /// date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; init; }

        /// <summary>
        /// Length in minutes
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int Duration { get; init; }

        /// <summary>
        /// event_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public int Event_id { get; init; }

        /// <summary>
        /// importance integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("importance")]
        public int Importance { get; init; }

        /// <summary>
        /// owner_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public int Owner_id { get; init; }

        /// <summary>
        /// owner_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("owner_name")]
        public string Owner_name { get; init; }

        /// <summary>
        /// owner_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("owner_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_calendar_event_id_okOwner_type Owner_type { get; init; }

        /// <summary>
        /// response string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("response")]
        public string Response { get; init; }

        /// <summary>
        /// text string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public string Text { get; init; }

        /// <summary>
        /// title string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; init; }

    }
