namespace EveOnlineApi;

    /// <summary>
    /// item object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Items
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Items(ItemsFlag @flag, int @quantity, int @type_id)

        {

            this.Flag = @flag;

            this.Quantity = @quantity;

            this.Type_id = @type_id;

        }    /// <summary>
        /// Fitting location for the item. Entries placed in 'Invalid' will be discarded. If this leaves the fitting with nothing, it will cause an error.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ItemsFlag Flag { get; init; }

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
