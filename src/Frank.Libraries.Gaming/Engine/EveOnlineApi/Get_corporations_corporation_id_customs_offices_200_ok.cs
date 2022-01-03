namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_customs_offices_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_customs_offices_200_ok(float? @alliance_tax_rate, bool @allow_access_with_standings, bool @allow_alliance_access, float? @bad_standing_tax_rate, float? @corporation_tax_rate, float? @excellent_standing_tax_rate, float? @good_standing_tax_rate, float? @neutral_standing_tax_rate, long @office_id, int @reinforce_exit_end, int @reinforce_exit_start, Get_corporations_corporation_id_customs_offices_200_okStanding_level? @standing_level, int @system_id, float? @terrible_standing_tax_rate)

        {

            this.Alliance_tax_rate = @alliance_tax_rate;

            this.Allow_access_with_standings = @allow_access_with_standings;

            this.Allow_alliance_access = @allow_alliance_access;

            this.Bad_standing_tax_rate = @bad_standing_tax_rate;

            this.Corporation_tax_rate = @corporation_tax_rate;

            this.Excellent_standing_tax_rate = @excellent_standing_tax_rate;

            this.Good_standing_tax_rate = @good_standing_tax_rate;

            this.Neutral_standing_tax_rate = @neutral_standing_tax_rate;

            this.Office_id = @office_id;

            this.Reinforce_exit_end = @reinforce_exit_end;

            this.Reinforce_exit_start = @reinforce_exit_start;

            this.Standing_level = @standing_level;

            this.System_id = @system_id;

            this.Terrible_standing_tax_rate = @terrible_standing_tax_rate;

        }    /// <summary>
        /// Only present if alliance access is allowed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_tax_rate")]
        public float? Alliance_tax_rate { get; init; }

        /// <summary>
        /// standing_level and any standing related tax rate only present when this is true
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allow_access_with_standings")]
        public bool Allow_access_with_standings { get; init; }

        /// <summary>
        /// allow_alliance_access boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allow_alliance_access")]
        public bool Allow_alliance_access { get; init; }

        /// <summary>
        /// bad_standing_tax_rate number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bad_standing_tax_rate")]
        public float? Bad_standing_tax_rate { get; init; }

        /// <summary>
        /// corporation_tax_rate number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_tax_rate")]
        public float? Corporation_tax_rate { get; init; }

        /// <summary>
        /// Tax rate for entities with excellent level of standing, only present if this level is allowed, same for all other standing related tax rates
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("excellent_standing_tax_rate")]
        public float? Excellent_standing_tax_rate { get; init; }

        /// <summary>
        /// good_standing_tax_rate number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("good_standing_tax_rate")]
        public float? Good_standing_tax_rate { get; init; }

        /// <summary>
        /// neutral_standing_tax_rate number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("neutral_standing_tax_rate")]
        public float? Neutral_standing_tax_rate { get; init; }

        /// <summary>
        /// unique ID of this customs office
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("office_id")]
        public long Office_id { get; init; }

        /// <summary>
        /// reinforce_exit_end integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reinforce_exit_end")]
        public int Reinforce_exit_end { get; init; }

        /// <summary>
        /// Together with reinforce_exit_end, marks a 2-hour period where this customs office could exit reinforcement mode during the day after initial attack
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reinforce_exit_start")]
        public int Reinforce_exit_start { get; init; }

        /// <summary>
        /// Access is allowed only for entities with this level of standing or better
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("standing_level")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_customs_offices_200_okStanding_level? Standing_level { get; init; }

        /// <summary>
        /// ID of the solar system this customs office is located in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// terrible_standing_tax_rate number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("terrible_standing_tax_rate")]
        public float? Terrible_standing_tax_rate { get; init; }

    }
