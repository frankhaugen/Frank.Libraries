using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

/// <summary>
///     Language to use in the response, takes precedence over Accept-Language
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Language
{
    [EnumMember(Value = @"en")] En = 0,

    [EnumMember(Value = @"en-us")] EnUs = 1,

    [EnumMember(Value = @"de")] De = 2,

    [EnumMember(Value = @"fr")] Fr = 3,

    [EnumMember(Value = @"ja")] Ja = 4,

    [EnumMember(Value = @"ru")] Ru = 5,

    [EnumMember(Value = @"zh")] Zh = 6,

    [EnumMember(Value = @"ko")] Ko = 7,

    [EnumMember(Value = @"es")] Es = 8
}