namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_fleets_fleet_id_members_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_fleets_fleet_id_members_200_ok(int @character_id, System.DateTimeOffset @join_time, Get_fleets_fleet_id_members_200_okRole @role, string @role_name, int @ship_type_id, int @solar_system_id, long @squad_id, long? @station_id, bool @takes_fleet_warp, long @wing_id)

        {

            this.Character_id = @character_id;

            this.Join_time = @join_time;

            this.Role = @role;

            this.Role_name = @role_name;

            this.Ship_type_id = @ship_type_id;

            this.Solar_system_id = @solar_system_id;

            this.Squad_id = @squad_id;

            this.Station_id = @station_id;

            this.Takes_fleet_warp = @takes_fleet_warp;

            this.Wing_id = @wing_id;

        }    /// <summary>
        /// character_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// join_time string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("join_time")]
        public System.DateTimeOffset Join_time { get; init; }

        /// <summary>
        /// Member’s role in fleet
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("role")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_fleets_fleet_id_members_200_okRole Role { get; init; }

        /// <summary>
        /// Localized role names
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string Role_name { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_type_id")]
        public int Ship_type_id { get; init; }

        /// <summary>
        /// Solar system the member is located in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int Solar_system_id { get; init; }

        /// <summary>
        /// ID of the squad the member is in. If not applicable, will be set to -1
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("squad_id")]
        public long Squad_id { get; init; }

        /// <summary>
        /// Station in which the member is docked in, if applicable
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("station_id")]
        public long? Station_id { get; init; }

        /// <summary>
        /// Whether the member take fleet warps
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("takes_fleet_warp")]
        public bool Takes_fleet_warp { get; init; }

        /// <summary>
        /// ID of the wing the member is in. If not applicable, will be set to -1
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("wing_id")]
        public long Wing_id { get; init; }

    }
