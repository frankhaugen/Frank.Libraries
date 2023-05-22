using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     planet object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Planets
{
    [JsonConstructor]
    public Planets(IList<int>? asteroid_belts, IList<int>? moons, int planet_id)

    {
        Asteroid_belts = asteroid_belts;

        Moons = moons;

        Planet_id = planet_id;
    }

    /// <summary>
    ///     asteroid_belts array
    /// </summary>

    [JsonPropertyName("asteroid_belts")]
    public IList<int>? Asteroid_belts { get; init; }

    /// <summary>
    ///     moons array
    /// </summary>

    [JsonPropertyName("moons")]
    public IList<int>? Moons { get; init; }

    /// <summary>
    ///     planet_id integer
    /// </summary>

    [JsonPropertyName("planet_id")]
    public int Planet_id { get; init; }
}