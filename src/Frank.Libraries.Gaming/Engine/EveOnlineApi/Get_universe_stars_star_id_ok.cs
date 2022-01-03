namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_stars_star_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_stars_star_id_ok(long @age, float @luminosity, string @name, long @radius, int @solar_system_id, Get_universe_stars_star_id_okSpectral_class @spectral_class, int @temperature, int @type_id)

        {

            this.Age = @age;

            this.Luminosity = @luminosity;

            this.Name = @name;

            this.Radius = @radius;

            this.Solar_system_id = @solar_system_id;

            this.Spectral_class = @spectral_class;

            this.Temperature = @temperature;

            this.Type_id = @type_id;

        }    /// <summary>
        /// Age of star in years
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("age")]
        public long Age { get; init; }

        /// <summary>
        /// luminosity number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("luminosity")]
        public float Luminosity { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// radius integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("radius")]
        public long Radius { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int Solar_system_id { get; init; }

        /// <summary>
        /// spectral_class string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("spectral_class")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_universe_stars_star_id_okSpectral_class Spectral_class { get; init; }

        /// <summary>
        /// temperature integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public int Temperature { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
