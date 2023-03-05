using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_contracts_200_okAvailability
{
    [EnumMember(Value = @"public")] Public = 0,

    [EnumMember(Value = @"personal")] Personal = 1,

    [EnumMember(Value = @"corporation")] Corporation = 2,

    [EnumMember(Value = @"alliance")] Alliance = 3
}