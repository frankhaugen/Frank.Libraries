namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_ancestries_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_ancestries_200_ok(int @bloodline_id, string @description, int? @icon_id, int @id, string @name, string? @short_description)

        {

            this.Bloodline_id = @bloodline_id;

            this.Description = @description;

            this.Icon_id = @icon_id;

            this.Id = @id;

            this.Name = @name;

            this.Short_description = @short_description;

        }    /// <summary>
        /// The bloodline associated with this ancestry
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bloodline_id")]
        public int Bloodline_id { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("icon_id")]
        public int? Icon_id { get; init; }

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

        /// <summary>
        /// short_description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("short_description")]
        public string? Short_description { get; init; }

    }
