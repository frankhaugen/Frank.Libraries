using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     Only list public structures that have this service online
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Filter
{
    [EnumMember(Value = @"market")] Market = 0,

    [EnumMember(Value = @"manufacturing_basic")]
    Manufacturing_basic = 1
}