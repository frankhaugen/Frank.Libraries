using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_industry_jobs_200_okStatus
{
    [EnumMember(Value = @"active")] Active = 0,

    [EnumMember(Value = @"cancelled")] Cancelled = 1,

    [EnumMember(Value = @"delivered")] Delivered = 2,

    [EnumMember(Value = @"paused")] Paused = 3,

    [EnumMember(Value = @"ready")] Ready = 4,

    [EnumMember(Value = @"reverted")] Reverted = 5
}