namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_planets_planet_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_planets_planet_id_ok(string @name, int @planet_id, Position4 @position, int @system_id, int @type_id)

        {

            this.Name = @name;

            this.Planet_id = @planet_id;

            this.Position = @position;

            this.System_id = @system_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// planet_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("planet_id")]
        public int Planet_id { get; init; }

        /// <summary>
        /// position object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position4 Position { get; init; }

        /// <summary>
        /// The solar system this planet is in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
