namespace EveOnlineApi;

    /// <summary>
    /// label object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_characters_character_id_mail_labels_label
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_characters_character_id_mail_labels_label(Post_characters_character_id_mail_labels_labelColor? @color, string @name)

        {

            this.Color = @color;

            this.Name = @name;

        }    /// <summary>
        /// Hexadecimal string representing label color, in RGB format
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("color")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Post_characters_character_id_mail_labels_labelColor? Color { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

    }
