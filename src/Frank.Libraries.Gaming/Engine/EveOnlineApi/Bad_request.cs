namespace EveOnlineApi;

    

    /// <summary>
    /// Bad request model
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Bad_request
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Bad_request(string @error)

        {

            this.Error = @error;

        }    /// <summary>
        /// Bad request message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; init; }

    }
