using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_universe_ids_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_universe_ids_ok(IList<Agents>? @agents, IList<Alliances>? @alliances, IList<Characters>? @characters, IList<Constellations>? @constellations, IList<Corporations>? @corporations, IList<Factions>? @factions, IList<Inventory_types>? @inventory_types, IList<Regions>? @regions, IList<Stations>? @stations, IList<Systems>? @systems)

        {

            this.Agents = @agents;

            this.Alliances = @alliances;

            this.Characters = @characters;

            this.Constellations = @constellations;

            this.Corporations = @corporations;

            this.Factions = @factions;

            this.Inventory_types = @inventory_types;

            this.Regions = @regions;

            this.Stations = @stations;

            this.Systems = @systems;

        }    /// <summary>
        /// agents array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("agents")]
        public IList<Agents>? Agents { get; init; }

        /// <summary>
        /// alliances array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliances")]
        public IList<Alliances>? Alliances { get; init; }

        /// <summary>
        /// characters array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("characters")]
        public IList<Characters>? Characters { get; init; }

        /// <summary>
        /// constellations array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("constellations")]
        public IList<Constellations>? Constellations { get; init; }

        /// <summary>
        /// corporations array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporations")]
        public IList<Corporations>? Corporations { get; init; }

        /// <summary>
        /// factions array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("factions")]
        public IList<Factions>? Factions { get; init; }

        /// <summary>
        /// inventory_types array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("inventory_types")]
        public IList<Inventory_types>? Inventory_types { get; init; }

        /// <summary>
        /// regions array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("regions")]
        public IList<Regions>? Regions { get; init; }

        /// <summary>
        /// stations array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("stations")]
        public IList<Stations>? Stations { get; init; }

        /// <summary>
        /// systems array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("systems")]
        public IList<Systems>? Systems { get; init; }

    }
