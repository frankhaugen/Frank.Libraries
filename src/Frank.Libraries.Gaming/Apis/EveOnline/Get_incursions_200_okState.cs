using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_incursions_200_okState
{
    [EnumMember(Value = @"withdrawing")] Withdrawing = 0,

    [EnumMember(Value = @"mobilizing")] Mobilizing = 1,

    [EnumMember(Value = @"established")] Established = 2
}