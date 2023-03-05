using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_alliancehistory_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_alliancehistory_200_ok(int? alliance_id, bool? is_deleted, int record_id, DateTimeOffset start_date)

    {
        Alliance_id = alliance_id;

        Is_deleted = is_deleted;

        Record_id = record_id;

        Start_date = start_date;
    }

    /// <summary>
    ///     alliance_id integer
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int? Alliance_id { get; init; }

    /// <summary>
    ///     True if the alliance has been closed
    /// </summary>

    [JsonPropertyName("is_deleted")]
    public bool? Is_deleted { get; init; }

    /// <summary>
    ///     An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
    /// </summary>

    [JsonPropertyName("record_id")]
    public int Record_id { get; init; }

    /// <summary>
    ///     start_date string
    /// </summary>

    [JsonPropertyName("start_date")]
    public DateTimeOffset Start_date { get; init; }
}