namespace EveOnlineApi;

    /// <summary>
    /// label object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Labels
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Labels(LabelsColor? @color, int? @label_id, string? @name, int? @unread_count)

        {

            this.Color = @color;

            this.Label_id = @label_id;

            this.Name = @name;

            this.Unread_count = @unread_count;

        }    /// <summary>
        /// color string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("color")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public LabelsColor? Color { get; init; }

        /// <summary>
        /// label_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("label_id")]
        public int? Label_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// unread_count integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unread_count")]
        public int? Unread_count { get; init; }

    }
