namespace EveOnlineApi;

    /// <summary>
    /// ally object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Allies
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Allies(int? @alliance_id, int? @corporation_id)

        {

            this.Alliance_id = @alliance_id;

            this.Corporation_id = @corporation_id;

        }    /// <summary>
        /// Alliance ID if and only if this ally is an alliance
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// Corporation ID if and only if this ally is a corporation
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int? Corporation_id { get; init; }

    }
