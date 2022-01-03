namespace EveOnlineApi;

    /// <summary>
    /// wallet transaction
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_wallets_division_transactions_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_wallets_division_transactions_200_ok(int @client_id, System.DateTimeOffset @date, bool @is_buy, long @journal_ref_id, long @location_id, int @quantity, long @transaction_id, int @type_id, double @unit_price)

        {

            this.Client_id = @client_id;

            this.Date = @date;

            this.Is_buy = @is_buy;

            this.Journal_ref_id = @journal_ref_id;

            this.Location_id = @location_id;

            this.Quantity = @quantity;

            this.Transaction_id = @transaction_id;

            this.Type_id = @type_id;

            this.Unit_price = @unit_price;

        }    /// <summary>
        /// client_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public int Client_id { get; init; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; init; }

        /// <summary>
        /// is_buy boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_buy")]
        public bool Is_buy { get; init; }

        /// <summary>
        /// -1 if there is no corresponding wallet journal entry
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("journal_ref_id")]
        public long Journal_ref_id { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// Unique transaction ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public long Transaction_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

        /// <summary>
        /// Amount paid per unit
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        public double Unit_price { get; init; }

    }
