namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_factions_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_factions_200_ok(int? @corporation_id, string @description, int @faction_id, bool @is_unique, int? @militia_corporation_id, string @name, float @size_factor, int? @solar_system_id, int @station_count, int @station_system_count)

        {

            this.Corporation_id = @corporation_id;

            this.Description = @description;

            this.Faction_id = @faction_id;

            this.Is_unique = @is_unique;

            this.Militia_corporation_id = @militia_corporation_id;

            this.Name = @name;

            this.Size_factor = @size_factor;

            this.Solar_system_id = @solar_system_id;

            this.Station_count = @station_count;

            this.Station_system_count = @station_system_count;

        }    /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int? Corporation_id { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int Faction_id { get; init; }

        /// <summary>
        /// is_unique boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_unique")]
        public bool Is_unique { get; init; }

        /// <summary>
        /// militia_corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("militia_corporation_id")]
        public int? Militia_corporation_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// size_factor number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("size_factor")]
        public float Size_factor { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int? Solar_system_id { get; init; }

        /// <summary>
        /// station_count integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("station_count")]
        public int Station_count { get; init; }

        /// <summary>
        /// station_system_count integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("station_system_count")]
        public int Station_system_count { get; init; }

    }
