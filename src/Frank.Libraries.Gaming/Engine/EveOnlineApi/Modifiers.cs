namespace EveOnlineApi;

    /// <summary>
    /// modifier object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Modifiers
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Modifiers(string? @domain, int? @effect_id, string @func, int? @modified_attribute_id, int? @modifying_attribute_id, int? @operator)

        {

            this.Domain = @domain;

            this.Effect_id = @effect_id;

            this.Func = @func;

            this.Modified_attribute_id = @modified_attribute_id;

            this.Modifying_attribute_id = @modifying_attribute_id;

            this.Operator = @operator;

        }    /// <summary>
        /// domain string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; init; }

        /// <summary>
        /// effect_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("effect_id")]
        public int? Effect_id { get; init; }

        /// <summary>
        /// func string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("func")]
        public string Func { get; init; }

        /// <summary>
        /// modified_attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("modified_attribute_id")]
        public int? Modified_attribute_id { get; init; }

        /// <summary>
        /// modifying_attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("modifying_attribute_id")]
        public int? Modifying_attribute_id { get; init; }

        /// <summary>
        /// operator integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("operator")]
        public int? Operator { get; init; }

    }
