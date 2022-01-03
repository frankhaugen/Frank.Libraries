namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_markets_prices_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_markets_prices_200_ok(double? @adjusted_price, double? @average_price, int @type_id)

        {

            this.Adjusted_price = @adjusted_price;

            this.Average_price = @average_price;

            this.Type_id = @type_id;

        }    /// <summary>
        /// adjusted_price number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("adjusted_price")]
        public double? Adjusted_price { get; init; }

        /// <summary>
        /// average_price number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("average_price")]
        public double? Average_price { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
