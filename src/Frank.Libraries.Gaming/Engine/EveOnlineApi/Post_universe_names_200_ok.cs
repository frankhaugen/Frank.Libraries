namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_universe_names_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_universe_names_200_ok(Post_universe_names_200_okCategory @category, int @id, string @name)

        {

            this.Category = @category;

            this.Id = @id;

            this.Name = @name;

        }    /// <summary>
        /// category string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("category")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Post_universe_names_200_okCategory Category { get; init; }

        /// <summary>
        /// id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

    }
