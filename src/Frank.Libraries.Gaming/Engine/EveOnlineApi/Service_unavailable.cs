namespace EveOnlineApi;

    /// <summary>
    /// Service unavailable model
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Service_unavailable
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Service_unavailable(string @error)

        {

            this.Error = @error;

        }    /// <summary>
        /// Service unavailable message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; init; }

    }
