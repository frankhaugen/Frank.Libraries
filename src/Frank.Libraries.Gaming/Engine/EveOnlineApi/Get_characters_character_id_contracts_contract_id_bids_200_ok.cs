namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_contracts_contract_id_bids_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_contracts_contract_id_bids_200_ok(float @amount, int @bid_id, int @bidder_id, System.DateTimeOffset @date_bid)

        {

            this.Amount = @amount;

            this.Bid_id = @bid_id;

            this.Bidder_id = @bidder_id;

            this.Date_bid = @date_bid;

        }    /// <summary>
        /// The amount bid, in ISK
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public float Amount { get; init; }

        /// <summary>
        /// Unique ID for the bid
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bid_id")]
        public int Bid_id { get; init; }

        /// <summary>
        /// Character ID of the bidder
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bidder_id")]
        public int Bidder_id { get; init; }

        /// <summary>
        /// Datetime when the bid was placed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date_bid")]
        public System.DateTimeOffset Date_bid { get; init; }

    }
