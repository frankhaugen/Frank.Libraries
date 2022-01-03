namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_orders_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_orders_200_ok(int @duration, double? @escrow, bool? @is_buy_order, System.DateTimeOffset @issued, int @issued_by, long @location_id, int? @min_volume, long @order_id, double @price, Get_corporations_corporation_id_orders_200_okRange @range, int @region_id, int @type_id, int @volume_remain, int @volume_total, int @wallet_division)

        {

            this.Duration = @duration;

            this.Escrow = @escrow;

            this.Is_buy_order = @is_buy_order;

            this.Issued = @issued;

            this.Issued_by = @issued_by;

            this.Location_id = @location_id;

            this.Min_volume = @min_volume;

            this.Order_id = @order_id;

            this.Price = @price;

            this.Range = @range;

            this.Region_id = @region_id;

            this.Type_id = @type_id;

            this.Volume_remain = @volume_remain;

            this.Volume_total = @volume_total;

            this.Wallet_division = @wallet_division;

        }    /// <summary>
        /// Number of days for which order is valid (starting from the issued date). An order expires at time issued + duration
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
        /// Date and time when this order was issued
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issued")]
        public System.DateTimeOffset Issued { get; init; }

        /// <summary>
        /// The character who issued this order
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issued_by")]
        public int Issued_by { get; init; }

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
        public Get_corporations_corporation_id_orders_200_okRange Range { get; init; }

        /// <summary>
        /// ID of the region where order was placed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int Region_id { get; init; }

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

        /// <summary>
        /// The corporation wallet division used for this order.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("wallet_division")]
        public int Wallet_division { get; init; }

    }
