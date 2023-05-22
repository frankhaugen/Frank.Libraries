using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_schematics_schematic_id_ok
{
    [JsonConstructor]
    public Get_universe_schematics_schematic_id_ok(int cycle_time, string schematic_name)

    {
        Cycle_time = cycle_time;

        Schematic_name = schematic_name;
    }

    /// <summary>
    ///     Time in seconds to process a run
    /// </summary>

    [JsonPropertyName("cycle_time")]
    public int Cycle_time { get; init; }

    /// <summary>
    ///     schematic_name string
    /// </summary>

    [JsonPropertyName("schematic_name")]
    public string Schematic_name { get; init; }
}