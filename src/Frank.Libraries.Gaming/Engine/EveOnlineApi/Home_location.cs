namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Home_location
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Home_location(long? @location_id, Home_locationLocation_type? @location_type)

        {

            this.Location_id = @location_id;

            this.Location_type = @location_type;

        }    /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long? Location_id { get; init; }

        /// <summary>
        /// location_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Home_locationLocation_type? Location_type { get; init; }

    }
