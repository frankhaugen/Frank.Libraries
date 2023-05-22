using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_divisions_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_divisions_ok(IList<Hangar>? hangar, IList<Wallet>? wallet)

    {
        Hangar = hangar;

        Wallet = wallet;
    }

    /// <summary>
    ///     hangar array
    /// </summary>

    [JsonPropertyName("hangar")]
    public IList<Hangar>? Hangar { get; init; }

    /// <summary>
    ///     wallet array
    /// </summary>

    [JsonPropertyName("wallet")]
    public IList<Wallet>? Wallet { get; init; }
}