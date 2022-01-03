namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Defender
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Defender(int? @alliance_id, int? @corporation_id, float @isk_destroyed, int @ships_killed)

        {

            this.Alliance_id = @alliance_id;

            this.Corporation_id = @corporation_id;

            this.Isk_destroyed = @isk_destroyed;

            this.Ships_killed = @ships_killed;

        }    /// <summary>
        /// Alliance ID if and only if the defender is an alliance
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// Corporation ID if and only if the defender is a corporation
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int? Corporation_id { get; init; }

        /// <summary>
        /// ISK value of ships the defender has killed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isk_destroyed")]
        public float Isk_destroyed { get; init; }

        /// <summary>
        /// The number of ships the defender has killed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ships_killed")]
        public int Ships_killed { get; init; }

    }
