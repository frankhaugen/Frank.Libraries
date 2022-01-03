namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_wallet_journal_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_wallet_journal_200_ok(double? @amount, double? @balance, long? @context_id, Get_characters_character_id_wallet_journal_200_okContext_id_type? @context_id_type, System.DateTimeOffset @date, string @description, int? @first_party_id, long @id, string? @reason, Get_characters_character_id_wallet_journal_200_okRef_type @ref_type, int? @second_party_id, double? @tax, int? @tax_receiver_id)

        {

            this.Amount = @amount;

            this.Balance = @balance;

            this.Context_id = @context_id;

            this.Context_id_type = @context_id_type;

            this.Date = @date;

            this.Description = @description;

            this.First_party_id = @first_party_id;

            this.Id = @id;

            this.Reason = @reason;

            this.Ref_type = @ref_type;

            this.Second_party_id = @second_party_id;

            this.Tax = @tax;

            this.Tax_receiver_id = @tax_receiver_id;

        }    /// <summary>
        /// The amount of ISK given or taken from the wallet as a result of the given transaction. Positive when ISK is deposited into the wallet and negative when ISK is withdrawn
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; init; }

        /// <summary>
        /// Wallet balance after transaction occurred
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double? Balance { get; init; }

        /// <summary>
        /// An ID that gives extra context to the particular transaction. Because of legacy reasons the context is completely different per ref_type and means different things. It is also possible to not have a context_id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("context_id")]
        public long? Context_id { get; init; }

        /// <summary>
        /// The type of the given context_id if present
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("context_id_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_wallet_journal_200_okContext_id_type? Context_id_type { get; init; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public System.DateTimeOffset Date { get; init; }

        /// <summary>
        /// The reason for the transaction, mirrors what is seen in the client
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// The id of the first party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types. The description attribute will help make sense of what this attribute means. For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("first_party_id")]
        public int? First_party_id { get; init; }

        /// <summary>
        /// Unique journal reference ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long Id { get; init; }

        /// <summary>
        /// The user stated reason for the transaction. Only applies to some ref_types
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; init; }

        /// <summary>
        /// "The transaction type for the given. transaction. Different transaction types will populate different attributes."
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ref_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_wallet_journal_200_okRef_type Ref_type { get; init; }

        /// <summary>
        /// The id of the second party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types. The description attribute will help make sense of what this attribute means. For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("second_party_id")]
        public int? Second_party_id { get; init; }

        /// <summary>
        /// Tax amount received. Only applies to tax related transactions
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("tax")]
        public double? Tax { get; init; }

        /// <summary>
        /// The corporation ID receiving any tax paid. Only applies to tax related transactions
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("tax_receiver_id")]
        public int? Tax_receiver_id { get; init; }

    }
