using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_stars_star_id_ok
{
    [JsonConstructor]
    public Get_universe_stars_star_id_ok(long age, float luminosity, string name, long radius, int solar_system_id, Get_universe_stars_star_id_okSpectral_class spectral_class, int temperature, int type_id)

    {
        Age = age;

        Luminosity = luminosity;

        Name = name;

        Radius = radius;

        Solar_system_id = solar_system_id;

        Spectral_class = spectral_class;

        Temperature = temperature;

        Type_id = type_id;
    }

    /// <summary>
    ///     Age of star in years
    /// </summary>

    [JsonPropertyName("age")]
    public long Age { get; init; }

    /// <summary>
    ///     luminosity number
    /// </summary>

    [JsonPropertyName("luminosity")]
    public float Luminosity { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     radius integer
    /// </summary>

    [JsonPropertyName("radius")]
    public long Radius { get; init; }

    /// <summary>
    ///     solar_system_id integer
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     spectral_class string
    /// </summary>

    [JsonPropertyName("spectral_class")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_universe_stars_star_id_okSpectral_class Spectral_class { get; init; }

    /// <summary>
    ///     temperature integer
    /// </summary>

    [JsonPropertyName("temperature")]
    public int Temperature { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}