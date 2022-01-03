namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_markets_region_id_history_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_markets_region_id_history_200_ok(double @average, System.DateTimeOffset @date, double @highest, double @lowest, long @order_count, long @volume)

        {

            this.Average = @average;

            this.Date = @date;

            this.Highest = @highest;

            this.Lowest = @lowest;

            this.Order_count = @order_count;

            this.Volume = @volume;

        }    /// <summary>
        /// average number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("average")]
        public double Average { get; init; }

        /// <summary>
        /// The date of this historical statistic entry
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset Date { get; init; }

        /// <summary>
        /// highest number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("highest")]
        public double Highest { get; init; }

        /// <summary>
        /// lowest number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("lowest")]
        public double Lowest { get; init; }

        /// <summary>
        /// Total number of orders happened that day
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("order_count")]
        public long Order_count { get; init; }

        /// <summary>
        /// Total
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volume")]
        public long Volume { get; init; }

    }
