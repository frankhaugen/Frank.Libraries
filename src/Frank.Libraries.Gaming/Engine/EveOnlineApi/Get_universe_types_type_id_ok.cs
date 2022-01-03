using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_types_type_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_types_type_id_ok(float? @capacity, string @description, IList<Dogma_attributes2>? @dogma_attributes, IList<Dogma_effects2>? @dogma_effects, int? @graphic_id, int @group_id, int? @icon_id, int? @market_group_id, float? @mass, string @name, float? @packaged_volume, int? @portion_size, bool @published, float? @radius, int @type_id, float? @volume)

        {

            this.Capacity = @capacity;

            this.Description = @description;

            this.Dogma_attributes = @dogma_attributes;

            this.Dogma_effects = @dogma_effects;

            this.Graphic_id = @graphic_id;

            this.Group_id = @group_id;

            this.Icon_id = @icon_id;

            this.Market_group_id = @market_group_id;

            this.Mass = @mass;

            this.Name = @name;

            this.Packaged_volume = @packaged_volume;

            this.Portion_size = @portion_size;

            this.Published = @published;

            this.Radius = @radius;

            this.Type_id = @type_id;

            this.Volume = @volume;

        }    /// <summary>
        /// capacity number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("capacity")]
        public float? Capacity { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// dogma_attributes array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dogma_attributes")]
        public IList<Dogma_attributes2>? Dogma_attributes { get; init; }

        /// <summary>
        /// dogma_effects array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("dogma_effects")]
        public IList<Dogma_effects2>? Dogma_effects { get; init; }

        /// <summary>
        /// graphic_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("graphic_id")]
        public int? Graphic_id { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int Group_id { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("icon_id")]
        public int? Icon_id { get; init; }

        /// <summary>
        /// This only exists for types that can be put on the market
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("market_group_id")]
        public int? Market_group_id { get; init; }

        /// <summary>
        /// mass number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("mass")]
        public float? Mass { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// packaged_volume number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("packaged_volume")]
        public float? Packaged_volume { get; init; }

        /// <summary>
        /// portion_size integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("portion_size")]
        public int? Portion_size { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published")]
        public bool Published { get; init; }

        /// <summary>
        /// radius number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("radius")]
        public float? Radius { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

        /// <summary>
        /// volume number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("volume")]
        public float? Volume { get; init; }

    }
