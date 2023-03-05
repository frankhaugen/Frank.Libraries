using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_contracts_200_okType
{
    [EnumMember(Value = @"unknown")] Unknown = 0,

    [EnumMember(Value = @"item_exchange")] Item_exchange = 1,

    [EnumMember(Value = @"auction")] Auction = 2,

    [EnumMember(Value = @"courier")] Courier = 3,

    [EnumMember(Value = @"loan")] Loan = 4
}