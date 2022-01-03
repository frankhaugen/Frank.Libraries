namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_titles_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_titles_200_ok(string? @name, int? @title_id)

        {

            this.Name = @name;

            this.Title_id = @title_id;

        }    /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// title_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title_id")]
        public int? Title_id { get; init; }

    }
