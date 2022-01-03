using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_dogma_effects_effect_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_dogma_effects_effect_id_ok(string? @description, bool? @disallow_auto_repeat, int? @discharge_attribute_id, string? @display_name, int? @duration_attribute_id, int? @effect_category, int @effect_id, bool? @electronic_chance, int? @falloff_attribute_id, int? @icon_id, bool? @is_assistance, bool? @is_offensive, bool? @is_warp_safe, IList<Modifiers>? @modifiers, string? @name, int? @post_expression, int? @pre_expression, bool? @published, int? @range_attribute_id, bool? @range_chance, int? @tracking_speed_attribute_id)

        {

            this.Description = @description;

            this.Disallow_auto_repeat = @disallow_auto_repeat;

            this.Discharge_attribute_id = @discharge_attribute_id;

            this.Display_name = @display_name;

            this.Duration_attribute_id = @duration_attribute_id;

            this.Effect_category = @effect_category;

            this.Effect_id = @effect_id;

            this.Electronic_chance = @electronic_chance;

            this.Falloff_attribute_id = @falloff_attribute_id;

            this.Icon_id = @icon_id;

            this.Is_assistance = @is_assistance;

            this.Is_offensive = @is_offensive;

            this.Is_warp_safe = @is_warp_safe;

            this.Modifiers = @modifiers;

            this.Name = @name;

            this.Post_expression = @post_expression;

            this.Pre_expression = @pre_expression;

            this.Published = @published;

            this.Range_attribute_id = @range_attribute_id;

            this.Range_chance = @range_chance;

            this.Tracking_speed_attribute_id = @tracking_speed_attribute_id;

        }    /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// disallow_auto_repeat boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("disallow_auto_repeat")]
        public bool? Disallow_auto_repeat { get; init; }

        /// <summary>
        /// discharge_attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("discharge_attribute_id")]
        public int? Discharge_attribute_id { get; init; }

        /// <summary>
        /// display_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? Display_name { get; init; }

        /// <summary>
        /// duration_attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("duration_attribute_id")]
        public int? Duration_attribute_id { get; init; }

        /// <summary>
        /// effect_category integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("effect_category")]
        public int? Effect_category { get; init; }

        /// <summary>
        /// effect_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("effect_id")]
        public int Effect_id { get; init; }

        /// <summary>
        /// electronic_chance boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("electronic_chance")]
        public bool? Electronic_chance { get; init; }

        /// <summary>
        /// falloff_attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("falloff_attribute_id")]
        public int? Falloff_attribute_id { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("icon_id")]
        public int? Icon_id { get; init; }

        /// <summary>
        /// is_assistance boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_assistance")]
        public bool? Is_assistance { get; init; }

        /// <summary>
        /// is_offensive boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_offensive")]
        public bool? Is_offensive { get; init; }

        /// <summary>
        /// is_warp_safe boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_warp_safe")]
        public bool? Is_warp_safe { get; init; }

        /// <summary>
        /// modifiers array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("modifiers")]
        public IList<Modifiers>? Modifiers { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// post_expression integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("post_expression")]
        public int? Post_expression { get; init; }

        /// <summary>
        /// pre_expression integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pre_expression")]
        public int? Pre_expression { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published")]
        public bool? Published { get; init; }

        /// <summary>
        /// range_attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("range_attribute_id")]
        public int? Range_attribute_id { get; init; }

        /// <summary>
        /// range_chance boolean
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("range_chance")]
        public bool? Range_chance { get; init; }

        /// <summary>
        /// tracking_speed_attribute_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("tracking_speed_attribute_id")]
        public int? Tracking_speed_attribute_id { get; init; }

    }
