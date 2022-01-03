namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Destination
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Destination(int @stargate_id, int @system_id)

        {

            this.Stargate_id = @stargate_id;

            this.System_id = @system_id;

        }    /// <summary>
        /// The stargate this stargate connects to
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("stargate_id")]
        public int Stargate_id { get; init; }

        /// <summary>
        /// The solar system this stargate connects to
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

    }
