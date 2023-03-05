using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_planets_planet_id_ok
{
    [JsonConstructor]
    public Get_characters_character_id_planets_planet_id_ok(IList<Links> links, IList<Pins> pins, IList<Routes> routes)

    {
        Links = links;

        Pins = pins;

        Routes = routes;
    }

    /// <summary>
    ///     links array
    /// </summary>

    [JsonPropertyName("links")]
    public IList<Links> Links { get; init; }

    /// <summary>
    ///     pins array
    /// </summary>

    [JsonPropertyName("pins")]
    public IList<Pins> Pins { get; init; }

    /// <summary>
    ///     routes array
    /// </summary>

    [JsonPropertyName("routes")]
    public IList<Routes> Routes { get; init; }
}