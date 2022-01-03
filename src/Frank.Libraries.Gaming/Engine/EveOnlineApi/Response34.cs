namespace EveOnlineApi;

    /// <summary>
    /// Error 520
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Response34
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Response34(string? @error)

        {

            this.Error = @error;

        }    /// <summary>
        /// Error 520 message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; init; }

    }
