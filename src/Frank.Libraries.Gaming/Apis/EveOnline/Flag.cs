using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

/// <summary>
///     route security preference
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Flag
{
    [EnumMember(Value = @"shortest")] Shortest = 0,

    [EnumMember(Value = @"secure")] Secure = 1,

    [EnumMember(Value = @"insecure")] Insecure = 2
}