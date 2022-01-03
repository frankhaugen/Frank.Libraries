namespace EveOnlineApi;

    /// <summary>
    /// recipient object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Recipients3
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Recipients3(int @recipient_id, Recipients3Recipient_type @recipient_type)

        {

            this.Recipient_id = @recipient_id;

            this.Recipient_type = @recipient_type;

        }    /// <summary>
        /// recipient_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipient_id")]
        public int Recipient_id { get; init; }

        /// <summary>
        /// recipient_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recipient_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Recipients3Recipient_type Recipient_type { get; init; }

    }
