using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_wallets_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_wallets_200_ok(double balance, int division)

    {
        Balance = balance;

        Division = division;
    }

    /// <summary>
    ///     balance number
    /// </summary>

    [JsonPropertyName("balance")]
    public double Balance { get; init; }

    /// <summary>
    ///     division integer
    /// </summary>

    [JsonPropertyName("division")]
    public int Division { get; init; }
}