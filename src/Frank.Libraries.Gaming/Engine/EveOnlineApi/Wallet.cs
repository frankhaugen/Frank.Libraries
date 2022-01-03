namespace EveOnlineApi;

    /// <summary>
    /// wallet object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Wallet
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Wallet(int? @division, string? @name)

        {

            this.Division = @division;

            this.Name = @name;

        }    /// <summary>
        /// division integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("division")]
        public int? Division { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

    }
