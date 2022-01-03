namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_contracts_contract_id_items_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_contracts_contract_id_items_200_ok(bool @is_included, bool @is_singleton, int @quantity, int? @raw_quantity, long @record_id, int @type_id)

        {

            this.Is_included = @is_included;

            this.Is_singleton = @is_singleton;

            this.Quantity = @quantity;

            this.Raw_quantity = @raw_quantity;

            this.Record_id = @record_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_included")]
        public bool Is_included { get; init; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_singleton")]
        public bool Is_singleton { get; init; }

        /// <summary>
        /// Number of items in the stack
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// -1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("raw_quantity")]
        public int? Raw_quantity { get; init; }

        /// <summary>
        /// Unique ID for the item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("record_id")]
        public long Record_id { get; init; }

        /// <summary>
        /// Type ID for item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
