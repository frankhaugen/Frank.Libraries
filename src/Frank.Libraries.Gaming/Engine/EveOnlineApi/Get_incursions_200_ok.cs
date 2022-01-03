using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_incursions_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_incursions_200_ok(int @constellation_id, int @faction_id, bool @has_boss, IList<int> @infested_solar_systems, float @influence, int @staging_solar_system_id, Get_incursions_200_okState @state, string @type)

        {

            this.Constellation_id = @constellation_id;

            this.Faction_id = @faction_id;

            this.Has_boss = @has_boss;

            this.Infested_solar_systems = @infested_solar_systems;

            this.Influence = @influence;

            this.Staging_solar_system_id = @staging_solar_system_id;

            this.State = @state;

            this.Type = @type;

        }    /// <summary>
        /// The constellation id in which this incursion takes place
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("constellation_id")]
        public int Constellation_id { get; init; }

        /// <summary>
        /// The attacking faction's id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int Faction_id { get; init; }

        /// <summary>
        /// Whether the final encounter has boss or not
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("has_boss")]
        public bool Has_boss { get; init; }

        /// <summary>
        /// A list of infested solar system ids that are a part of this incursion
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("infested_solar_systems")]
        public IList<int> Infested_solar_systems { get; init; }

        /// <summary>
        /// Influence of this incursion as a float from 0 to 1
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("influence")]
        public float Influence { get; init; }

        /// <summary>
        /// Staging solar system for this incursion
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("staging_solar_system_id")]
        public int Staging_solar_system_id { get; init; }

        /// <summary>
        /// The state of this incursion
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("state")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_incursions_200_okState State { get; init; }

        /// <summary>
        /// The type of this incursion
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; init; }

    }
