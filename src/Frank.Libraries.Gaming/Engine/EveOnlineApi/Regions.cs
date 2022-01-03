namespace EveOnlineApi;

    /// <summary>
    /// region object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Regions
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Regions(int? @id, string? @name)

        {

            this.Id = @id;

            this.Name = @name;

        }    /// <summary>
        /// id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

    }
