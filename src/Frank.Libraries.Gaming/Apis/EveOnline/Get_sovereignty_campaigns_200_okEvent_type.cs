using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_sovereignty_campaigns_200_okEvent_type
{
    [EnumMember(Value = @"tcu_defense")] Tcu_defense = 0,

    [EnumMember(Value = @"ihub_defense")] Ihub_defense = 1,

    [EnumMember(Value = @"station_defense")]
    Station_defense = 2,

    [EnumMember(Value = @"station_freeport")]
    Station_freeport = 3
}