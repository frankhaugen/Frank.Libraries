using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_membertracking_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_membertracking_200_ok(int? base_id, int character_id, long? location_id, DateTimeOffset? logoff_date, DateTimeOffset? logon_date, int? ship_type_id, DateTimeOffset? start_date)

    {
        Base_id = base_id;

        Character_id = character_id;

        Location_id = location_id;

        Logoff_date = logoff_date;

        Logon_date = logon_date;

        Ship_type_id = ship_type_id;

        Start_date = start_date;
    }

    /// <summary>
    ///     base_id integer
    /// </summary>

    [JsonPropertyName("base_id")]
    public int? Base_id { get; init; }

    /// <summary>
    ///     character_id integer
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     location_id integer
    /// </summary>

    [JsonPropertyName("location_id")]
    public long? Location_id { get; init; }

    /// <summary>
    ///     logoff_date string
    /// </summary>

    [JsonPropertyName("logoff_date")]
    public DateTimeOffset? Logoff_date { get; init; }

    /// <summary>
    ///     logon_date string
    /// </summary>

    [JsonPropertyName("logon_date")]
    public DateTimeOffset? Logon_date { get; init; }

    /// <summary>
    ///     ship_type_id integer
    /// </summary>

    [JsonPropertyName("ship_type_id")]
    public int? Ship_type_id { get; init; }

    /// <summary>
    ///     start_date string
    /// </summary>

    [JsonPropertyName("start_date")]
    public DateTimeOffset? Start_date { get; init; }
}