using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_starbases_200_okState
{
    [EnumMember(Value = @"offline")] Offline = 0,

    [EnumMember(Value = @"online")] Online = 1,

    [EnumMember(Value = @"onlining")] Onlining = 2,

    [EnumMember(Value = @"reinforced")] Reinforced = 3,

    [EnumMember(Value = @"unanchoring")] Unanchoring = 4
}