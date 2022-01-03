namespace EveOnlineApi;

    /// <summary>
    /// required_item object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Required_items
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Required_items(int @quantity, int @type_id)

        {

            this.Quantity = @quantity;

            this.Type_id = @type_id;

        }    /// <summary>
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
