namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_structures_structure_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_structures_structure_id_ok(string @name, int @owner_id, Position7? @position, int @solar_system_id, int? @type_id)

        {

            this.Name = @name;

            this.Owner_id = @owner_id;

            this.Position = @position;

            this.Solar_system_id = @solar_system_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// The full name of the structure
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// The ID of the corporation who owns this particular structure
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public int Owner_id { get; init; }

        /// <summary>
        /// Coordinates of the structure in Cartesian space relative to the Sun, in metres.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position7? Position { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int Solar_system_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int? Type_id { get; init; }

    }
