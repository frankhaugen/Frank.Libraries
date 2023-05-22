using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_wallet_journal_200_okContext_id_type
{
    [EnumMember(Value = @"structure_id")] Structure_id = 0,

    [EnumMember(Value = @"station_id")] Station_id = 1,

    [EnumMember(Value = @"market_transaction_id")]
    Market_transaction_id = 2,

    [EnumMember(Value = @"character_id")] Character_id = 3,

    [EnumMember(Value = @"corporation_id")]
    Corporation_id = 4,

    [EnumMember(Value = @"alliance_id")] Alliance_id = 5,

    [EnumMember(Value = @"eve_system")] Eve_system = 6,

    [EnumMember(Value = @"industry_job_id")]
    Industry_job_id = 7,

    [EnumMember(Value = @"contract_id")] Contract_id = 8,

    [EnumMember(Value = @"planet_id")] Planet_id = 9,

    [EnumMember(Value = @"system_id")] System_id = 10,

    [EnumMember(Value = @"type_id")] Type_id = 11
}