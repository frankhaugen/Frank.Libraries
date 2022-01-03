namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_notifications_contacts_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_notifications_contacts_200_ok(string @message, int @notification_id, System.DateTimeOffset @send_date, int @sender_character_id, float @standing_level)

        {

            this.Message = @message;

            this.Notification_id = @notification_id;

            this.Send_date = @send_date;

            this.Sender_character_id = @sender_character_id;

            this.Standing_level = @standing_level;

        }    /// <summary>
        /// message string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; init; }

        /// <summary>
        /// notification_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("notification_id")]
        public int Notification_id { get; init; }

        /// <summary>
        /// send_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("send_date")]
        public System.DateTimeOffset Send_date { get; init; }

        /// <summary>
        /// sender_character_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sender_character_id")]
        public int Sender_character_id { get; init; }

        /// <summary>
        /// A number representing the standing level the receiver has been added at by the sender. The standing levels are as follows: -10 -&gt; Terrible | -5 -&gt; Bad |  0 -&gt; Neutral |  5 -&gt; Good |  10 -&gt; Excellent
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("standing_level")]
        public float Standing_level { get; init; }

    }
