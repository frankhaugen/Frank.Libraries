namespace EveOnlineApi;

    /// <summary>
    /// service object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Services
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Services(string @name, ServicesState @state)

        {

            this.Name = @name;

            this.State = @state;

        }    /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// state string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("state")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ServicesState State { get; init; }

    }
