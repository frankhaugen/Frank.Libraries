using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_constellations_constellation_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_constellations_constellation_id_ok(int @constellation_id, string @name, Position2 @position, int @region_id, IList<int> @systems)

        {

            this.Constellation_id = @constellation_id;

            this.Name = @name;

            this.Position = @position;

            this.Region_id = @region_id;

            this.Systems = @systems;

        }    /// <summary>
        /// constellation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("constellation_id")]
        public int Constellation_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position2 Position { get; init; }

        /// <summary>
        /// The region this constellation is in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int Region_id { get; init; }

        /// <summary>
        /// systems array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("systems")]
        public IList<int> Systems { get; init; }

    }
