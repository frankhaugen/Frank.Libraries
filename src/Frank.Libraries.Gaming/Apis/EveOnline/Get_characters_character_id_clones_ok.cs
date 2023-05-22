using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_clones_ok
{
    [JsonConstructor]
    public Get_characters_character_id_clones_ok(Home_location? home_location, IList<Jump_clones> jump_clones, DateTimeOffset? last_clone_jump_date, DateTimeOffset? last_station_change_date)

    {
        Home_location = home_location;

        Jump_clones = jump_clones;

        Last_clone_jump_date = last_clone_jump_date;

        Last_station_change_date = last_station_change_date;
    }

    /// <summary>
    ///     home_location object
    /// </summary>

    [JsonPropertyName("home_location")]
    public Home_location? Home_location { get; init; }

    /// <summary>
    ///     jump_clones array
    /// </summary>

    [JsonPropertyName("jump_clones")]
    public IList<Jump_clones> Jump_clones { get; init; }

    /// <summary>
    ///     last_clone_jump_date string
    /// </summary>

    [JsonPropertyName("last_clone_jump_date")]
    public DateTimeOffset? Last_clone_jump_date { get; init; }

    /// <summary>
    ///     last_station_change_date string
    /// </summary>

    [JsonPropertyName("last_station_change_date")]
    public DateTimeOffset? Last_station_change_date { get; init; }
}