namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_membertracking_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_membertracking_200_ok(int? @base_id, int @character_id, long? @location_id, System.DateTimeOffset? @logoff_date, System.DateTimeOffset? @logon_date, int? @ship_type_id, System.DateTimeOffset? @start_date)

        {

            this.Base_id = @base_id;

            this.Character_id = @character_id;

            this.Location_id = @location_id;

            this.Logoff_date = @logoff_date;

            this.Logon_date = @logon_date;

            this.Ship_type_id = @ship_type_id;

            this.Start_date = @start_date;

        }    /// <summary>
        /// base_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("base_id")]
        public int? Base_id { get; init; }

        /// <summary>
        /// character_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long? Location_id { get; init; }

        /// <summary>
        /// logoff_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("logoff_date")]
        public System.DateTimeOffset? Logoff_date { get; init; }

        /// <summary>
        /// logon_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("logon_date")]
        public System.DateTimeOffset? Logon_date { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_type_id")]
        public int? Ship_type_id { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public System.DateTimeOffset? Start_date { get; init; }

    }
