using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_search_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_search_ok(IList<int>? @agent, IList<int>? @alliance, IList<int>? @character, IList<int>? @constellation, IList<int>? @corporation, IList<int>? @faction, IList<int>? @inventory_type, IList<int>? @region, IList<int>? @solar_system, IList<int>? @station, IList<long>? @structure)

        {

            this.Agent = @agent;

            this.Alliance = @alliance;

            this.Character = @character;

            this.Constellation = @constellation;

            this.Corporation = @corporation;

            this.Faction = @faction;

            this.Inventory_type = @inventory_type;

            this.Region = @region;

            this.Solar_system = @solar_system;

            this.Station = @station;

            this.Structure = @structure;

        }    /// <summary>
        /// agent array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("agent")]
        public IList<int>? Agent { get; init; }

        /// <summary>
        /// alliance array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance")]
        public IList<int>? Alliance { get; init; }

        /// <summary>
        /// character array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character")]
        public IList<int>? Character { get; init; }

        /// <summary>
        /// constellation array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("constellation")]
        public IList<int>? Constellation { get; init; }

        /// <summary>
        /// corporation array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation")]
        public IList<int>? Corporation { get; init; }

        /// <summary>
        /// faction array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction")]
        public IList<int>? Faction { get; init; }

        /// <summary>
        /// inventory_type array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
        public IList<int>? Inventory_type { get; init; }

        /// <summary>
        /// region array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("region")]
        public IList<int>? Region { get; init; }

        /// <summary>
        /// solar_system array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system")]
        public IList<int>? Solar_system { get; init; }

        /// <summary>
        /// station array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("station")]
        public IList<int>? Station { get; init; }

        /// <summary>
        /// structure array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("structure")]
        public IList<long>? Structure { get; init; }

    }
