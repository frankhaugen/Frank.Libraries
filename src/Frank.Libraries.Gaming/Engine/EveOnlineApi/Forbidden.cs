namespace EveOnlineApi;

    /// <summary>
    /// Forbidden model
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Forbidden
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Forbidden(string @error, int? @sso_status)

        {

            this.Error = @error;

            this.Sso_status = @sso_status;

        }    /// <summary>
        /// Forbidden message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; init; }

        /// <summary>
        /// status code received from SSO
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sso_status")]
        public int? Sso_status { get; init; }

    }
