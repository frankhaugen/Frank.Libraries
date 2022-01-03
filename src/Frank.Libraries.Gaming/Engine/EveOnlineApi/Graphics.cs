namespace EveOnlineApi;

    /// <summary>
    /// graphic object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Graphics
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Graphics(int? @color, string @graphic, int @layer, int @part)

        {

            this.Color = @color;

            this.Graphic = @graphic;

            this.Layer = @layer;

            this.Part = @part;

        }    /// <summary>
        /// color integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("color")]
        public int? Color { get; init; }

        /// <summary>
        /// graphic string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("graphic")]
        public string Graphic { get; init; }

        /// <summary>
        /// layer integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("layer")]
        public int Layer { get; init; }

        /// <summary>
        /// part integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("part")]
        public int Part { get; init; }

    }
