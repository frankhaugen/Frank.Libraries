namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_medals_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_medals_200_ok(System.DateTimeOffset @created_at, int @creator_id, string @description, int @medal_id, string @title)

        {

            this.Created_at = @created_at;

            this.Creator_id = @creator_id;

            this.Description = @description;

            this.Medal_id = @medal_id;

            this.Title = @title;

        }    /// <summary>
        /// created_at string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public System.DateTimeOffset Created_at { get; init; }

        /// <summary>
        /// ID of the character who created this medal
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public int Creator_id { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("medal_id")]
        public int Medal_id { get; init; }

        /// <summary>
        /// title string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; init; }

    }
