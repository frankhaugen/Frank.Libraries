namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_planets_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_planets_200_ok(System.DateTimeOffset @last_update, int @num_pins, int @owner_id, int @planet_id, Get_characters_character_id_planets_200_okPlanet_type @planet_type, int @solar_system_id, int @upgrade_level)

        {

            this.Last_update = @last_update;

            this.Num_pins = @num_pins;

            this.Owner_id = @owner_id;

            this.Planet_id = @planet_id;

            this.Planet_type = @planet_type;

            this.Solar_system_id = @solar_system_id;

            this.Upgrade_level = @upgrade_level;

        }    /// <summary>
        /// last_update string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_update")]
        public System.DateTimeOffset Last_update { get; init; }

        /// <summary>
        /// num_pins integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("num_pins")]
        public int Num_pins { get; init; }

        /// <summary>
        /// owner_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public int Owner_id { get; init; }

        /// <summary>
        /// planet_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("planet_id")]
        public int Planet_id { get; init; }

        /// <summary>
        /// planet_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("planet_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_planets_200_okPlanet_type Planet_type { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int Solar_system_id { get; init; }

        /// <summary>
        /// upgrade_level integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("upgrade_level")]
        public int Upgrade_level { get; init; }

    }
