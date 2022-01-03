namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_notifications_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_notifications_200_ok(bool? @is_read, long @notification_id, int @sender_id, Get_characters_character_id_notifications_200_okSender_type @sender_type, string? @text, System.DateTimeOffset @timestamp, Get_characters_character_id_notifications_200_okType @type)

        {

            this.Is_read = @is_read;

            this.Notification_id = @notification_id;

            this.Sender_id = @sender_id;

            this.Sender_type = @sender_type;

            this.Text = @text;

            this.Timestamp = @timestamp;

            this.Type = @type;

        }    /// <summary>
        /// is_read boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_read")]
        public bool? Is_read { get; init; }

        /// <summary>
        /// notification_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("notification_id")]
        public long Notification_id { get; init; }

        /// <summary>
        /// sender_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public int Sender_id { get; init; }

        /// <summary>
        /// sender_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sender_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_notifications_200_okSender_type Sender_type { get; init; }

        /// <summary>
        /// text string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; init; }

        /// <summary>
        /// timestamp string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public System.DateTimeOffset Timestamp { get; init; }

        /// <summary>
        /// type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_notifications_200_okType Type { get; init; }

    }
