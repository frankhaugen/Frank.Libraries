namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_assets_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_assets_200_ok(bool? @is_blueprint_copy, bool @is_singleton, long @item_id, Get_characters_character_id_assets_200_okLocation_flag @location_flag, long @location_id, Get_characters_character_id_assets_200_okLocation_type @location_type, int @quantity, int @type_id)

        {

            this.Is_blueprint_copy = @is_blueprint_copy;

            this.Is_singleton = @is_singleton;

            this.Item_id = @item_id;

            this.Location_flag = @location_flag;

            this.Location_id = @location_id;

            this.Location_type = @location_type;

            this.Quantity = @quantity;

            this.Type_id = @type_id;

        }    /// <summary>
        /// is_blueprint_copy boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_blueprint_copy")]
        public bool? Is_blueprint_copy { get; init; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_singleton")]
        public bool Is_singleton { get; init; }

        /// <summary>
        /// item_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public long Item_id { get; init; }

        /// <summary>
        /// location_flag string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_assets_200_okLocation_flag Location_flag { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// location_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_assets_200_okLocation_type Location_type { get; init; }

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
