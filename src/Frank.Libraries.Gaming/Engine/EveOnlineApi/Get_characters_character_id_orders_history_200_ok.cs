namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_orders_history_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_orders_history_200_ok(int @duration, double? @escrow, bool? @is_buy_order, bool @is_corporation, System.DateTimeOffset @issued, long @location_id, int? @min_volume, long @order_id, double @price, Get_characters_character_id_orders_history_200_okRange @range, int @region_id, Get_characters_character_id_orders_history_200_okState @state, int @type_id, int @volume_remain, int @volume_total)

        {

            this.Duration = @duration;

            this.Escrow = @escrow;

            this.Is_buy_order = @is_buy_order;

            this.Is_corporation = @is_corporation;

            this.Issued = @issued;

            this.Location_id = @location_id;

            this.Min_volume = @min_volume;

            this.Order_id = @order_id;

            this.Price = @price;

            this.Range = @range;

            this.Region_id = @region_id;

            this.State = @state;

            this.Type_id = @type_id;

            this.Volume_remain = @volume_remain;

            this.Volume_total = @volume_total;

        }    /// <summary>
        /// Number of days the order was valid for (starting from the issued date). An order expires at time issued + duration
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int Duration { get; init; }

        /// <summary>
        /// For buy orders, the amount of ISK in escrow
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("escrow")]
        public double? Escrow { get; init; }

        /// <summary>
        /// True if the order is a bid (buy) order
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_buy_order")]
        public bool? Is_buy_order { get; init; }

        /// <summary>
        /// Signifies whether the buy/sell order was placed on behalf of a corporation.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_corporation")]
        public bool Is_corporation { get; init; }

        /// <summary>
        /// Date and time when this order was issued
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issued")]
        public System.DateTimeOffset Issued { get; init; }

        /// <summary>
        /// ID of the location where order was placed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// For buy orders, the minimum quantity that will be accepted in a matching sell order
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("min_volume")]
        public int? Min_volume { get; init; }

        /// <summary>
        /// Unique order ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long Order_id { get; init; }

        /// <summary>
        /// Cost per unit for this order
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; init; }

        /// <summary>
        /// Valid order range, numbers are ranges in jumps
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("range")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_orders_history_200_okRange Range { get; init; }

        /// <summary>
        /// ID of the region where order was placed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int Region_id { get; init; }

        /// <summary>
        /// Current order state
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("state")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_orders_history_200_okState State { get; init; }

        /// <summary>
        /// The type ID of the item transacted in this order
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

        /// <summary>
        /// Quantity of items still required or offered
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volume_remain")]
        public int Volume_remain { get; init; }

        /// <summary>
        /// Quantity of items required or offered at time order was placed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volume_total")]
        public int Volume_total { get; init; }

    }
