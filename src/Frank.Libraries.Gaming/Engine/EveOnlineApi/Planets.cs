using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// planet object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Planets
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Planets(IList<int>? @asteroid_belts, IList<int>? @moons, int @planet_id)

        {

            this.Asteroid_belts = @asteroid_belts;

            this.Moons = @moons;

            this.Planet_id = @planet_id;

        }    /// <summary>
        /// asteroid_belts array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("asteroid_belts")]
        public IList<int>? Asteroid_belts { get; init; }

        /// <summary>
        /// moons array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("moons")]
        public IList<int>? Moons { get; init; }

        /// <summary>
        /// planet_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("planet_id")]
        public int Planet_id { get; init; }

    }
