namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_fw_wars_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_fw_wars_200_ok(int @against_id, int @faction_id)

        {

            this.Against_id = @against_id;

            this.Faction_id = @faction_id;

        }    /// <summary>
        /// The faction ID of the enemy faction.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("against_id")]
        public int Against_id { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int Faction_id { get; init; }

    }
