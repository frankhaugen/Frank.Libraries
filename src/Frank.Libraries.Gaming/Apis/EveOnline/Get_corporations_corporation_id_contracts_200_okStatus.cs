using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_contracts_200_okStatus
{
    [EnumMember(Value = @"outstanding")] Outstanding = 0,

    [EnumMember(Value = @"in_progress")] In_progress = 1,

    [EnumMember(Value = @"finished_issuer")]
    Finished_issuer = 2,

    [EnumMember(Value = @"finished_contractor")]
    Finished_contractor = 3,

    [EnumMember(Value = @"finished")] Finished = 4,

    [EnumMember(Value = @"cancelled")] Cancelled = 5,

    [EnumMember(Value = @"rejected")] Rejected = 6,

    [EnumMember(Value = @"failed")] Failed = 7,

    [EnumMember(Value = @"deleted")] Deleted = 8,

    [EnumMember(Value = @"reversed")] Reversed = 9
}