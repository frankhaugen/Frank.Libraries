namespace EveOnlineApi;

    /// <summary>
    /// cost_indice object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Cost_indices
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Cost_indices(Cost_indicesActivity @activity, float @cost_index)

        {

            this.Activity = @activity;

            this.Cost_index = @cost_index;

        }    /// <summary>
        /// activity string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("activity")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Cost_indicesActivity Activity { get; init; }

        /// <summary>
        /// cost_index number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cost_index")]
        public float Cost_index { get; init; }

    }
