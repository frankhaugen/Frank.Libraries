namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_races_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_races_200_ok(int @alliance_id, string @description, string @name, int @race_id)

        {

            this.Alliance_id = @alliance_id;

            this.Description = @description;

            this.Name = @name;

            this.Race_id = @race_id;

        }    /// <summary>
        /// The alliance generally associated with this race
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int Alliance_id { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("race_id")]
        public int Race_id { get; init; }

    }
