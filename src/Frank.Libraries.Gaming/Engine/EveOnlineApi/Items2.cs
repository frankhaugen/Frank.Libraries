namespace EveOnlineApi;

    /// <summary>
    /// item object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Items2
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Items2(Items2Flag @flag, int @quantity, int @type_id)

        {

            this.Flag = @flag;

            this.Quantity = @quantity;

            this.Type_id = @type_id;

        }    /// <summary>
        /// flag string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Items2Flag Flag { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
