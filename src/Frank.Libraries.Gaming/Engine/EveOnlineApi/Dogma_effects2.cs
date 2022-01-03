namespace EveOnlineApi;

    /// <summary>
    /// dogma_effect object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Dogma_effects2
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Dogma_effects2(int @effect_id, bool @is_default)

        {

            this.Effect_id = @effect_id;

            this.Is_default = @is_default;

        }    /// <summary>
        /// effect_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("effect_id")]
        public int Effect_id { get; init; }

        /// <summary>
        /// is_default boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool Is_default { get; init; }

    }
