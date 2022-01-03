namespace EveOnlineApi;

    /// <summary>
    /// fuel object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Fuels
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Fuels(int @quantity, int @type_id)

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
