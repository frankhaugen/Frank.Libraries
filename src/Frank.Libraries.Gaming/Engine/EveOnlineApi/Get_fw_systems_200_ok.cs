namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_fw_systems_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_fw_systems_200_ok(Get_fw_systems_200_okContested @contested, int @occupier_faction_id, int @owner_faction_id, int @solar_system_id, int @victory_points, int @victory_points_threshold)

        {

            this.Contested = @contested;

            this.Occupier_faction_id = @occupier_faction_id;

            this.Owner_faction_id = @owner_faction_id;

            this.Solar_system_id = @solar_system_id;

            this.Victory_points = @victory_points;

            this.Victory_points_threshold = @victory_points_threshold;

        }    /// <summary>
        /// contested string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contested")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_fw_systems_200_okContested Contested { get; init; }

        /// <summary>
        /// occupier_faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("occupier_faction_id")]
        public int Occupier_faction_id { get; init; }

        /// <summary>
        /// owner_faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("owner_faction_id")]
        public int Owner_faction_id { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int Solar_system_id { get; init; }

        /// <summary>
        /// victory_points integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("victory_points")]
        public int Victory_points { get; init; }

        /// <summary>
        /// victory_points_threshold integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("victory_points_threshold")]
        public int Victory_points_threshold { get; init; }

    }
