namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_ok(int? @alliance_id, int @ceo_id, int @creator_id, System.DateTimeOffset? @date_founded, string? @description, int? @faction_id, int? @home_station_id, int @member_count, string @name, long? @shares, float @tax_rate, string @ticker, string? @url, bool? @war_eligible)

        {

            this.Alliance_id = @alliance_id;

            this.Ceo_id = @ceo_id;

            this.Creator_id = @creator_id;

            this.Date_founded = @date_founded;

            this.Description = @description;

            this.Faction_id = @faction_id;

            this.Home_station_id = @home_station_id;

            this.Member_count = @member_count;

            this.Name = @name;

            this.Shares = @shares;

            this.Tax_rate = @tax_rate;

            this.Ticker = @ticker;

            this.Url = @url;

            this.War_eligible = @war_eligible;

        }    /// <summary>
        /// ID of the alliance that corporation is a member of, if any
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// ceo_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ceo_id")]
        public int Ceo_id { get; init; }

        /// <summary>
        /// creator_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public int Creator_id { get; init; }

        /// <summary>
        /// date_founded string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("date_founded")]
        public System.DateTimeOffset? Date_founded { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

        /// <summary>
        /// home_station_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("home_station_id")]
        public int? Home_station_id { get; init; }

        /// <summary>
        /// member_count integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("member_count")]
        public int Member_count { get; init; }

        /// <summary>
        /// the full name of the corporation
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// shares integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shares")]
        public long? Shares { get; init; }

        /// <summary>
        /// tax_rate number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
        public float Tax_rate { get; init; }

        /// <summary>
        /// the short name of the corporation
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ticker")]
        public string Ticker { get; init; }

        /// <summary>
        /// url string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; init; }

        /// <summary>
        /// war_eligible boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("war_eligible")]
        public bool? War_eligible { get; init; }

    }
