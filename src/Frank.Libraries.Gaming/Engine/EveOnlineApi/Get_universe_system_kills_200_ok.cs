namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_system_kills_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_system_kills_200_ok(int @npc_kills, int @pod_kills, int @ship_kills, int @system_id)

        {

            this.Npc_kills = @npc_kills;

            this.Pod_kills = @pod_kills;

            this.Ship_kills = @ship_kills;

            this.System_id = @system_id;

        }    /// <summary>
        /// Number of NPC ships killed in this system
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("npc_kills")]
        public int Npc_kills { get; init; }

        /// <summary>
        /// Number of pods killed in this system
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pod_kills")]
        public int Pod_kills { get; init; }

        /// <summary>
        /// Number of player ships killed in this system
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_kills")]
        public int Ship_kills { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

    }
