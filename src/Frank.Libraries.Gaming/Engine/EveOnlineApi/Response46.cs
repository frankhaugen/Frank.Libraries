namespace EveOnlineApi;

    /// <summary>
    /// Schematic not found
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Response46
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Response46(string? @error)

        {

            this.Error = @error;

        }    /// <summary>
        /// error message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; init; }

    }
