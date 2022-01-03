namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_asteroid_belts_asteroid_belt_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_asteroid_belts_asteroid_belt_id_ok(string @name, Position @position, int @system_id)

        {

            this.Name = @name;

            this.Position = @position;

            this.System_id = @system_id;

        }    /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position Position { get; init; }

        /// <summary>
        /// The solar system this asteroid belt is in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

    }
