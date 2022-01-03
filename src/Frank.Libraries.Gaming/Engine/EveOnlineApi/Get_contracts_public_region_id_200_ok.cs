namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_contracts_public_region_id_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_contracts_public_region_id_200_ok(double? @buyout, double? @collateral, int @contract_id, System.DateTimeOffset @date_expired, System.DateTimeOffset @date_issued, int? @days_to_complete, long? @end_location_id, bool? @for_corporation, int @issuer_corporation_id, int @issuer_id, double? @price, double? @reward, long? @start_location_id, string? @title, Get_contracts_public_region_id_200_okType @type, double? @volume)

        {

            this.Buyout = @buyout;

            this.Collateral = @collateral;

            this.Contract_id = @contract_id;

            this.Date_expired = @date_expired;

            this.Date_issued = @date_issued;

            this.Days_to_complete = @days_to_complete;

            this.End_location_id = @end_location_id;

            this.For_corporation = @for_corporation;

            this.Issuer_corporation_id = @issuer_corporation_id;

            this.Issuer_id = @issuer_id;

            this.Price = @price;

            this.Reward = @reward;

            this.Start_location_id = @start_location_id;

            this.Title = @title;

            this.Type = @type;

            this.Volume = @volume;

        }    /// <summary>
        /// Buyout price (for Auctions only)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("buyout")]
        public double? Buyout { get; init; }

        /// <summary>
        /// Collateral price (for Couriers only)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("collateral")]
        public double? Collateral { get; init; }

        /// <summary>
        /// contract_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public int Contract_id { get; init; }

        /// <summary>
        /// Expiration date of the contract
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date_expired")]
        public System.DateTimeOffset Date_expired { get; init; }

        /// <summary>
        /// Сreation date of the contract
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date_issued")]
        public System.DateTimeOffset Date_issued { get; init; }

        /// <summary>
        /// Number of days to perform the contract
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("days_to_complete")]
        public int? Days_to_complete { get; init; }

        /// <summary>
        /// End location ID (for Couriers contract)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("end_location_id")]
        public long? End_location_id { get; init; }

        /// <summary>
        /// true if the contract was issued on behalf of the issuer's corporation
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("for_corporation")]
        public bool? For_corporation { get; init; }

        /// <summary>
        /// Character's corporation ID for the issuer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issuer_corporation_id")]
        public int Issuer_corporation_id { get; init; }

        /// <summary>
        /// Character ID for the issuer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issuer_id")]
        public int Issuer_id { get; init; }

        /// <summary>
        /// Price of contract (for ItemsExchange and Auctions)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; init; }

        /// <summary>
        /// Remuneration for contract (for Couriers only)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reward")]
        public double? Reward { get; init; }

        /// <summary>
        /// Start location ID (for Couriers contract)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("start_location_id")]
        public long? Start_location_id { get; init; }

        /// <summary>
        /// Title of the contract
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

        /// <summary>
        /// Type of the contract
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_contracts_public_region_id_200_okType Type { get; init; }

        /// <summary>
        /// Volume of items in the contract
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; init; }

    }
