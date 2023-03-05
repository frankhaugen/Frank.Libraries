using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_dogma_effects_effect_id_ok
{
    [JsonConstructor]
    public Get_dogma_effects_effect_id_ok(string? description, bool? disallow_auto_repeat, int? discharge_attribute_id, string? display_name, int? duration_attribute_id, int? effect_category, int effect_id, bool? electronic_chance, int? falloff_attribute_id, int? icon_id, bool? is_assistance, bool? is_offensive, bool? is_warp_safe, IList<Modifiers>? modifiers, string? name, int? post_expression, int? pre_expression, bool? published, int? range_attribute_id, bool? range_chance, int? tracking_speed_attribute_id)

    {
        Description = description;

        Disallow_auto_repeat = disallow_auto_repeat;

        Discharge_attribute_id = discharge_attribute_id;

        Display_name = display_name;

        Duration_attribute_id = duration_attribute_id;

        Effect_category = effect_category;

        Effect_id = effect_id;

        Electronic_chance = electronic_chance;

        Falloff_attribute_id = falloff_attribute_id;

        Icon_id = icon_id;

        Is_assistance = is_assistance;

        Is_offensive = is_offensive;

        Is_warp_safe = is_warp_safe;

        Modifiers = modifiers;

        Name = name;

        Post_expression = post_expression;

        Pre_expression = pre_expression;

        Published = published;

        Range_attribute_id = range_attribute_id;

        Range_chance = range_chance;

        Tracking_speed_attribute_id = tracking_speed_attribute_id;
    }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    ///     disallow_auto_repeat boolean
    /// </summary>

    [JsonPropertyName("disallow_auto_repeat")]
    public bool? Disallow_auto_repeat { get; init; }

    /// <summary>
    ///     discharge_attribute_id integer
    /// </summary>

    [JsonPropertyName("discharge_attribute_id")]
    public int? Discharge_attribute_id { get; init; }

    /// <summary>
    ///     display_name string
    /// </summary>

    [JsonPropertyName("display_name")]
    public string? Display_name { get; init; }

    /// <summary>
    ///     duration_attribute_id integer
    /// </summary>

    [JsonPropertyName("duration_attribute_id")]
    public int? Duration_attribute_id { get; init; }

    /// <summary>
    ///     effect_category integer
    /// </summary>

    [JsonPropertyName("effect_category")]
    public int? Effect_category { get; init; }

    /// <summary>
    ///     effect_id integer
    /// </summary>

    [JsonPropertyName("effect_id")]
    public int Effect_id { get; init; }

    /// <summary>
    ///     electronic_chance boolean
    /// </summary>

    [JsonPropertyName("electronic_chance")]
    public bool? Electronic_chance { get; init; }

    /// <summary>
    ///     falloff_attribute_id integer
    /// </summary>

    [JsonPropertyName("falloff_attribute_id")]
    public int? Falloff_attribute_id { get; init; }

    /// <summary>
    ///     icon_id integer
    /// </summary>

    [JsonPropertyName("icon_id")]
    public int? Icon_id { get; init; }

    /// <summary>
    ///     is_assistance boolean
    /// </summary>

    [JsonPropertyName("is_assistance")]
    public bool? Is_assistance { get; init; }

    /// <summary>
    ///     is_offensive boolean
    /// </summary>

    [JsonPropertyName("is_offensive")]
    public bool? Is_offensive { get; init; }

    /// <summary>
    ///     is_warp_safe boolean
    /// </summary>

    [JsonPropertyName("is_warp_safe")]
    public bool? Is_warp_safe { get; init; }

    /// <summary>
    ///     modifiers array
    /// </summary>

    [JsonPropertyName("modifiers")]
    public IList<Modifiers>? Modifiers { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    ///     post_expression integer
    /// </summary>

    [JsonPropertyName("post_expression")]
    public int? Post_expression { get; init; }

    /// <summary>
    ///     pre_expression integer
    /// </summary>

    [JsonPropertyName("pre_expression")]
    public int? Pre_expression { get; init; }

    /// <summary>
    ///     published boolean
    /// </summary>

    [JsonPropertyName("published")]
    public bool? Published { get; init; }

    /// <summary>
    ///     range_attribute_id integer
    /// </summary>

    [JsonPropertyName("range_attribute_id")]
    public int? Range_attribute_id { get; init; }

    /// <summary>
    ///     range_chance boolean
    /// </summary>

    [JsonPropertyName("range_chance")]
    public bool? Range_chance { get; init; }

    /// <summary>
    ///     tracking_speed_attribute_id integer
    /// </summary>

    [JsonPropertyName("tracking_speed_attribute_id")]
    public int? Tracking_speed_attribute_id { get; init; }
}