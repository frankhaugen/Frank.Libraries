namespace EveOnlineApi;

    /// <summary>
    /// head object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Heads
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Heads(int @head_id, float @latitude, float @longitude)

        {

            this.Head_id = @head_id;

            this.Latitude = @latitude;

            this.Longitude = @longitude;

        }    /// <summary>
        /// head_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("head_id")]
        public int Head_id { get; init; }

        /// <summary>
        /// latitude number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public float Latitude { get; init; }

        /// <summary>
        /// longitude number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public float Longitude { get; init; }

    }
