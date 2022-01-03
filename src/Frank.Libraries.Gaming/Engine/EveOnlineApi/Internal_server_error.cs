namespace EveOnlineApi;

    /// <summary>
    /// Internal server error model
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Internal_server_error
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Internal_server_error(string @error)

        {

            this.Error = @error;

        }    /// <summary>
        /// Internal server error message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; init; }

    }
