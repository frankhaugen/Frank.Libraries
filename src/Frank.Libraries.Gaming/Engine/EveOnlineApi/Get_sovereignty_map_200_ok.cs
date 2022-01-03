namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_sovereignty_map_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_sovereignty_map_200_ok(int? @alliance_id, int? @corporation_id, int? @faction_id, int @system_id)

        {

            this.Alliance_id = @alliance_id;

            this.Corporation_id = @corporation_id;

            this.Faction_id = @faction_id;

            this.System_id = @system_id;

        }    /// <summary>
        /// alliance_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int? Corporation_id { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

    }
