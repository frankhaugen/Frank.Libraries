namespace EveOnlineApi;

    /// <summary>
    /// Unprocessable entity
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Response69
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Response69(string? @error)

        {

            this.Error = @error;

        }    /// <summary>
        /// Unprocessable entity message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; init; }

    }
