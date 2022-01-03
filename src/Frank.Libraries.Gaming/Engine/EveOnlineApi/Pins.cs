using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// pin object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Pins
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Pins(IList<Contents>? @contents, System.DateTimeOffset? @expiry_time, Extractor_details? @extractor_details, Factory_details? @factory_details, System.DateTimeOffset? @install_time, System.DateTimeOffset? @last_cycle_start, float @latitude, float @longitude, long @pin_id, int? @schematic_id, int @type_id)

        {

            this.Contents = @contents;

            this.Expiry_time = @expiry_time;

            this.Extractor_details = @extractor_details;

            this.Factory_details = @factory_details;

            this.Install_time = @install_time;

            this.Last_cycle_start = @last_cycle_start;

            this.Latitude = @latitude;

            this.Longitude = @longitude;

            this.Pin_id = @pin_id;

            this.Schematic_id = @schematic_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// contents array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("contents")]
        public IList<Contents>? Contents { get; init; }

        /// <summary>
        /// expiry_time string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("expiry_time")]
        public System.DateTimeOffset? Expiry_time { get; init; }

        /// <summary>
        /// extractor_details object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("extractor_details")]
        public Extractor_details? Extractor_details { get; init; }

        /// <summary>
        /// factory_details object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("factory_details")]
        public Factory_details? Factory_details { get; init; }

        /// <summary>
        /// install_time string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("install_time")]
        public System.DateTimeOffset? Install_time { get; init; }

        /// <summary>
        /// last_cycle_start string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_cycle_start")]
        public System.DateTimeOffset? Last_cycle_start { get; init; }

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

        /// <summary>
        /// pin_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pin_id")]
        public long Pin_id { get; init; }

        /// <summary>
        /// schematic_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("schematic_id")]
        public int? Schematic_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
