namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_alliances_alliance_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_alliances_alliance_id_ok(int @creator_corporation_id, int @creator_id, System.DateTimeOffset @date_founded, int? @executor_corporation_id, int? @faction_id, string @name, string @ticker)

        {

            this.Creator_corporation_id = @creator_corporation_id;

            this.Creator_id = @creator_id;

            this.Date_founded = @date_founded;

            this.Executor_corporation_id = @executor_corporation_id;

            this.Faction_id = @faction_id;

            this.Name = @name;

            this.Ticker = @ticker;

        }    /// <summary>
        /// ID of the corporation that created the alliance
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("creator_corporation_id")]
        public int Creator_corporation_id { get; init; }

        /// <summary>
        /// ID of the character that created the alliance
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public int Creator_id { get; init; }

        /// <summary>
        /// date_founded string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date_founded")]
        public System.DateTimeOffset Date_founded { get; init; }

        /// <summary>
        /// the executor corporation ID, if this alliance is not closed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("executor_corporation_id")]
        public int? Executor_corporation_id { get; init; }

        /// <summary>
        /// Faction ID this alliance is fighting for, if this alliance is enlisted in factional warfare
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

        /// <summary>
        /// the full name of the alliance
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// the short name of the alliance
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ticker")]
        public string Ticker { get; init; }

    }
