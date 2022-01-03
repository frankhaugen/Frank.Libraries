namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_stargates_stargate_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_stargates_stargate_id_ok(Destination @destination, string @name, Position5 @position, int @stargate_id, int @system_id, int @type_id)

        {

            this.Destination = @destination;

            this.Name = @name;

            this.Position = @position;

            this.Stargate_id = @stargate_id;

            this.System_id = @system_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// destination object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("destination")]
        public Destination Destination { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position5 Position { get; init; }

        /// <summary>
        /// stargate_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("stargate_id")]
        public int Stargate_id { get; init; }

        /// <summary>
        /// The solar system this stargate is in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
