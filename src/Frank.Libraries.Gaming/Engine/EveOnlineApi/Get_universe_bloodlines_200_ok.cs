namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_bloodlines_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_bloodlines_200_ok(int @bloodline_id, int @charisma, int @corporation_id, string @description, int @intelligence, int @memory, string @name, int @perception, int @race_id, int? @ship_type_id, int @willpower)

        {

            this.Bloodline_id = @bloodline_id;

            this.Charisma = @charisma;

            this.Corporation_id = @corporation_id;

            this.Description = @description;

            this.Intelligence = @intelligence;

            this.Memory = @memory;

            this.Name = @name;

            this.Perception = @perception;

            this.Race_id = @race_id;

            this.Ship_type_id = @ship_type_id;

            this.Willpower = @willpower;

        }    /// <summary>
        /// bloodline_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bloodline_id")]
        public int Bloodline_id { get; init; }

        /// <summary>
        /// charisma integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("charisma")]
        public int Charisma { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int Corporation_id { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// intelligence integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        public int Intelligence { get; init; }

        /// <summary>
        /// memory integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("memory")]
        public int Memory { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// perception integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("perception")]
        public int Perception { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("race_id")]
        public int Race_id { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_type_id")]
        public int? Ship_type_id { get; init; }

        /// <summary>
        /// willpower integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("willpower")]
        public int Willpower { get; init; }

    }
