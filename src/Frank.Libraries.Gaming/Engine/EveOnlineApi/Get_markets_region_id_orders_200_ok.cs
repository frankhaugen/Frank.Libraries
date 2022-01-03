namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_markets_region_id_orders_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_markets_region_id_orders_200_ok(int @duration, bool @is_buy_order, System.DateTimeOffset @issued, long @location_id, int @min_volume, long @order_id, double @price, Get_markets_region_id_orders_200_okRange @range, int @system_id, int @type_id, int @volume_remain, int @volume_total)

        {

            this.Duration = @duration;

            this.Is_buy_order = @is_buy_order;

            this.Issued = @issued;

            this.Location_id = @location_id;

            this.Min_volume = @min_volume;

            this.Order_id = @order_id;

            this.Price = @price;

            this.Range = @range;

            this.System_id = @system_id;

            this.Type_id = @type_id;

            this.Volume_remain = @volume_remain;

            this.Volume_total = @volume_total;

        }    /// <summary>
        /// duration integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int Duration { get; init; }

        /// <summary>
        /// is_buy_order boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_buy_order")]
        public bool Is_buy_order { get; init; }

        /// <summary>
        /// issued string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issued")]
        public System.DateTimeOffset Issued { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// min_volume integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("min_volume")]
        public int Min_volume { get; init; }

        /// <summary>
        /// order_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long Order_id { get; init; }

        /// <summary>
        /// price number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; init; }

        /// <summary>
        /// range string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("range")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_markets_region_id_orders_200_okRange Range { get; init; }

        /// <summary>
        /// The solar system this order was placed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

        /// <summary>
        /// volume_remain integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volume_remain")]
        public int Volume_remain { get; init; }

        /// <summary>
        /// volume_total integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volume_total")]
        public int Volume_total { get; init; }

    }
