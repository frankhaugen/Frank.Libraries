namespace EveOnlineApi;

    /// <summary>
    /// dogma_attribute object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Dogma_attributes2
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Dogma_attributes2(int @attribute_id, float @value)

        {

            this.Attribute_id = @attribute_id;

            this.Value = @value;

        }    /// <summary>
        /// attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("attribute_id")]
        public int Attribute_id { get; init; }

        /// <summary>
        /// value number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public float Value { get; init; }

    }
