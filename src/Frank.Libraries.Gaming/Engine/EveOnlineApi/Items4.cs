namespace EveOnlineApi;

    /// <summary>
    /// item object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Items4
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Items4(int @flag, int @item_type_id, long? @quantity_destroyed, long? @quantity_dropped, int @singleton)

        {

            this.Flag = @flag;

            this.Item_type_id = @item_type_id;

            this.Quantity_destroyed = @quantity_destroyed;

            this.Quantity_dropped = @quantity_dropped;

            this.Singleton = @singleton;

        }    /// <summary>
        /// flag integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("flag")]
        public int Flag { get; init; }

        /// <summary>
        /// item_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("item_type_id")]
        public int Item_type_id { get; init; }

        /// <summary>
        /// quantity_destroyed integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity_destroyed")]
        public long? Quantity_destroyed { get; init; }

        /// <summary>
        /// quantity_dropped integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity_dropped")]
        public long? Quantity_dropped { get; init; }

        /// <summary>
        /// singleton integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("singleton")]
        public int Singleton { get; init; }

    }
