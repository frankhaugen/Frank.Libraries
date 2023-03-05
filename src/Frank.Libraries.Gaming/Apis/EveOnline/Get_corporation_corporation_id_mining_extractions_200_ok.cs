using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporation_corporation_id_mining_extractions_200_ok
{
    [JsonConstructor]
    public Get_corporation_corporation_id_mining_extractions_200_ok(DateTimeOffset chunk_arrival_time, DateTimeOffset extraction_start_time, int moon_id, DateTimeOffset natural_decay_time, long structure_id)

    {
        Chunk_arrival_time = chunk_arrival_time;

        Extraction_start_time = extraction_start_time;

        Moon_id = moon_id;

        Natural_decay_time = natural_decay_time;

        Structure_id = structure_id;
    }

    /// <summary>
    ///     The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill.
    ///     <br />
    /// </summary>

    [JsonPropertyName("chunk_arrival_time")]
    public DateTimeOffset Chunk_arrival_time { get; init; }

    /// <summary>
    ///     The time at which the current extraction was initiated.
    ///     <br />
    /// </summary>

    [JsonPropertyName("extraction_start_time")]
    public DateTimeOffset Extraction_start_time { get; init; }

    /// <summary>
    ///     moon_id integer
    /// </summary>

    [JsonPropertyName("moon_id")]
    public int Moon_id { get; init; }

    /// <summary>
    ///     The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining
    ///     drill.
    ///     <br />
    /// </summary>

    [JsonPropertyName("natural_decay_time")]
    public DateTimeOffset Natural_decay_time { get; init; }

    /// <summary>
    ///     structure_id integer
    /// </summary>

    [JsonPropertyName("structure_id")]
    public long Structure_id { get; init; }
}