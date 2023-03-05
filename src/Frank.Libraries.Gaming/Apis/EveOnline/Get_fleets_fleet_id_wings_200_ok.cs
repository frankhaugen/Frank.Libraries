using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_fleets_fleet_id_wings_200_ok
{
    [JsonConstructor]
    public Get_fleets_fleet_id_wings_200_ok(long id, string name, IList<Squads> squads)

    {
        Id = id;

        Name = name;

        Squads = squads;
    }

    /// <summary>
    ///     id integer
    /// </summary>

    [JsonPropertyName("id")]
    public long Id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     squads array
    /// </summary>

    [JsonPropertyName("squads")]
    public IList<Squads> Squads { get; init; }
}