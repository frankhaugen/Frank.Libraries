namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Position
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Position(double @x, double @y, double @z)

        {

            this.X = @x;

            this.Y = @y;

            this.Z = @z;

        }    /// <summary>
        /// x number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("x")]
        public double X { get; init; }

        /// <summary>
        /// y number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("y")]
        public double Y { get; init; }

        /// <summary>
        /// z number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("z")]
        public double Z { get; init; }

    }
