using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_roles_history_200_okRole_type
{
    [EnumMember(Value = @"grantable_roles")]
    Grantable_roles = 0,

    [EnumMember(Value = @"grantable_roles_at_base")]
    Grantable_roles_at_base = 1,

    [EnumMember(Value = @"grantable_roles_at_hq")]
    Grantable_roles_at_hq = 2,

    [EnumMember(Value = @"grantable_roles_at_other")]
    Grantable_roles_at_other = 3,

    [EnumMember(Value = @"roles")] Roles = 4,

    [EnumMember(Value = @"roles_at_base")] Roles_at_base = 5,

    [EnumMember(Value = @"roles_at_hq")] Roles_at_hq = 6,

    [EnumMember(Value = @"roles_at_other")]
    Roles_at_other = 7
}