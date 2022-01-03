namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_schematics_schematic_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_schematics_schematic_id_ok(int @cycle_time, string @schematic_name)

        {

            this.Cycle_time = @cycle_time;

            this.Schematic_name = @schematic_name;

        }    /// <summary>
        /// Time in seconds to process a run
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cycle_time")]
        public int Cycle_time { get; init; }

        /// <summary>
        /// schematic_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("schematic_name")]
        public string Schematic_name { get; init; }

    }
