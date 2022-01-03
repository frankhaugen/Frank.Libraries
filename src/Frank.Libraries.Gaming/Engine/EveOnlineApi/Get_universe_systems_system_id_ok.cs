using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_systems_system_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_systems_system_id_ok(int @constellation_id, string @name, IList<Planets>? @planets, Position8 @position, string? @security_class, float @security_status, int? @star_id, IList<int>? @stargates, IList<int>? @stations, int @system_id)

        {

            this.Constellation_id = @constellation_id;

            this.Name = @name;

            this.Planets = @planets;

            this.Position = @position;

            this.Security_class = @security_class;

            this.Security_status = @security_status;

            this.Star_id = @star_id;

            this.Stargates = @stargates;

            this.Stations = @stations;

            this.System_id = @system_id;

        }    /// <summary>
        /// The constellation this solar system is in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("constellation_id")]
        public int Constellation_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// planets array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("planets")]
        public IList<Planets>? Planets { get; init; }

        /// <summary>
        /// position object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position8 Position { get; init; }

        /// <summary>
        /// security_class string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("security_class")]
        public string? Security_class { get; init; }

        /// <summary>
        /// security_status number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("security_status")]
        public float Security_status { get; init; }

        /// <summary>
        /// star_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("star_id")]
        public int? Star_id { get; init; }

        /// <summary>
        /// stargates array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("stargates")]
        public IList<int>? Stargates { get; init; }

        /// <summary>
        /// stations array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("stations")]
        public IList<int>? Stations { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

    }
