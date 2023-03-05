using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_fw_systems_200_okContested
{
    [EnumMember(Value = @"captured")] Captured = 0,

    [EnumMember(Value = @"contested")] Contested = 1,

    [EnumMember(Value = @"uncontested")] Uncontested = 2,

    [EnumMember(Value = @"vulnerable")] Vulnerable = 3
}