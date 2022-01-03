namespace EveOnlineApi;

    /// <summary>
    /// Gateway timeout model
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Gateway_timeout
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Gateway_timeout(string @error, int? @timeout)

        {

            this.Error = @error;

            this.Timeout = @timeout;

        }    /// <summary>
        /// Gateway timeout message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; init; }

        /// <summary>
        /// number of seconds the request was given
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; init; }

    }
