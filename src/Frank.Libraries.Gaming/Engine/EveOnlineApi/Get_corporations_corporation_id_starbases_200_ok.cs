namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_starbases_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_starbases_200_ok(int? @moon_id, System.DateTimeOffset? @onlined_since, System.DateTimeOffset? @reinforced_until, long @starbase_id, Get_corporations_corporation_id_starbases_200_okState? @state, int @system_id, int @type_id, System.DateTimeOffset? @unanchor_at)

        {

            this.Moon_id = @moon_id;

            this.Onlined_since = @onlined_since;

            this.Reinforced_until = @reinforced_until;

            this.Starbase_id = @starbase_id;

            this.State = @state;

            this.System_id = @system_id;

            this.Type_id = @type_id;

            this.Unanchor_at = @unanchor_at;

        }    /// <summary>
        /// The moon this starbase (POS) is anchored on, unanchored POSes do not have this information
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("moon_id")]
        public int? Moon_id { get; init; }

        /// <summary>
        /// When the POS onlined, for starbases (POSes) in online state
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("onlined_since")]
        public System.DateTimeOffset? Onlined_since { get; init; }

        /// <summary>
        /// When the POS will be out of reinforcement, for starbases (POSes) in reinforced state
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reinforced_until")]
        public System.DateTimeOffset? Reinforced_until { get; init; }

        /// <summary>
        /// Unique ID for this starbase (POS)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("starbase_id")]
        public long Starbase_id { get; init; }

        /// <summary>
        /// state string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("state")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_starbases_200_okState? State { get; init; }

        /// <summary>
        /// The solar system this starbase (POS) is in, unanchored POSes have this information
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// Starbase (POS) type
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

        /// <summary>
        /// When the POS started unanchoring, for starbases (POSes) in unanchoring state
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unanchor_at")]
        public System.DateTimeOffset? Unanchor_at { get; init; }

    }
