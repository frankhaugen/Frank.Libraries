using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_graphics_graphic_id_ok
{
    [JsonConstructor]
    public Get_universe_graphics_graphic_id_ok(string? collision_file, string? graphic_file, int graphic_id, string? icon_folder, string? sof_dna, string? sof_fation_name, string? sof_hull_name, string? sof_race_name)

    {
        Collision_file = collision_file;

        Graphic_file = graphic_file;

        Graphic_id = graphic_id;

        Icon_folder = icon_folder;

        Sof_dna = sof_dna;

        Sof_fation_name = sof_fation_name;

        Sof_hull_name = sof_hull_name;

        Sof_race_name = sof_race_name;
    }

    /// <summary>
    ///     collision_file string
    /// </summary>

    [JsonPropertyName("collision_file")]
    public string? Collision_file { get; init; }

    /// <summary>
    ///     graphic_file string
    /// </summary>

    [JsonPropertyName("graphic_file")]
    public string? Graphic_file { get; init; }

    /// <summary>
    ///     graphic_id integer
    /// </summary>

    [JsonPropertyName("graphic_id")]
    public int Graphic_id { get; init; }

    /// <summary>
    ///     icon_folder string
    /// </summary>

    [JsonPropertyName("icon_folder")]
    public string? Icon_folder { get; init; }

    /// <summary>
    ///     sof_dna string
    /// </summary>

    [JsonPropertyName("sof_dna")]
    public string? Sof_dna { get; init; }

    /// <summary>
    ///     sof_fation_name string
    /// </summary>

    [JsonPropertyName("sof_fation_name")]
    public string? Sof_fation_name { get; init; }

    /// <summary>
    ///     sof_hull_name string
    /// </summary>

    [JsonPropertyName("sof_hull_name")]
    public string? Sof_hull_name { get; init; }

    /// <summary>
    ///     sof_race_name string
    /// </summary>

    [JsonPropertyName("sof_race_name")]
    public string? Sof_race_name { get; init; }
}