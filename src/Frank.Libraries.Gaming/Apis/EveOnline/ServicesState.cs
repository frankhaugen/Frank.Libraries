using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum ServicesState
{
    [EnumMember(Value = @"online")] Online = 0,

    [EnumMember(Value = @"offline")] Offline = 1,

    [EnumMember(Value = @"cleanup")] Cleanup = 2
}