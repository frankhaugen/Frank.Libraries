namespace EveOnlineApi;

    /// <summary>
    /// No image server for this datasource
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Response22
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Response22(string? @error)

        {

            this.Error = @error;

        }    /// <summary>
        /// error message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; init; }

    }
