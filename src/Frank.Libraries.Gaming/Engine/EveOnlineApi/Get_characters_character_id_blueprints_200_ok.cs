namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_blueprints_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_blueprints_200_ok(long @item_id, Get_characters_character_id_blueprints_200_okLocation_flag @location_flag, long @location_id, int @material_efficiency, int @quantity, int @runs, int @time_efficiency, int @type_id)

        {

            this.Item_id = @item_id;

            this.Location_flag = @location_flag;

            this.Location_id = @location_id;

            this.Material_efficiency = @material_efficiency;

            this.Quantity = @quantity;

            this.Runs = @runs;

            this.Time_efficiency = @time_efficiency;

            this.Type_id = @type_id;

        }    /// <summary>
        /// Unique ID for this item.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public long Item_id { get; init; }

        /// <summary>
        /// Type of the location_id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_blueprints_200_okLocation_flag Location_flag { get; init; }

        /// <summary>
        /// References a station, a ship or an item_id if this blueprint is located within a container. If the return value is an item_id, then the Character AssetList API must be queried to find the container using the given item_id to determine the correct location of the Blueprint.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// Material Efficiency Level of the blueprint.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("material_efficiency")]
        public int Material_efficiency { get; init; }

        /// <summary>
        /// A range of numbers with a minimum of -2 and no maximum value where -1 is an original and -2 is a copy. It can be a positive integer if it is a stack of blueprint originals fresh from the market (e.g. no activities performed on them yet).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// Number of runs remaining if the blueprint is a copy, -1 if it is an original.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("runs")]
        public int Runs { get; init; }

        /// <summary>
        /// Time Efficiency Level of the blueprint.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("time_efficiency")]
        public int Time_efficiency { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
