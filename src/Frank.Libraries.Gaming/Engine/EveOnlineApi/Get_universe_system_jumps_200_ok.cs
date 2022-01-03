namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_system_jumps_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_system_jumps_200_ok(int @ship_jumps, int @system_id)

        {

            this.Ship_jumps = @ship_jumps;

            this.System_id = @system_id;

        }    /// <summary>
        /// ship_jumps integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_jumps")]
        public int Ship_jumps { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

    }
