using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_structures_200_okState
{
    [EnumMember(Value = @"anchor_vulnerable")]
    Anchor_vulnerable = 0,

    [EnumMember(Value = @"anchoring")] Anchoring = 1,

    [EnumMember(Value = @"armor_reinforce")]
    Armor_reinforce = 2,

    [EnumMember(Value = @"armor_vulnerable")]
    Armor_vulnerable = 3,

    [EnumMember(Value = @"deploy_vulnerable")]
    Deploy_vulnerable = 4,

    [EnumMember(Value = @"fitting_invulnerable")]
    Fitting_invulnerable = 5,

    [EnumMember(Value = @"hull_reinforce")]
    Hull_reinforce = 6,

    [EnumMember(Value = @"hull_vulnerable")]
    Hull_vulnerable = 7,

    [EnumMember(Value = @"online_deprecated")]
    Online_deprecated = 8,

    [EnumMember(Value = @"onlining_vulnerable")]
    Onlining_vulnerable = 9,

    [EnumMember(Value = @"shield_vulnerable")]
    Shield_vulnerable = 10,

    [EnumMember(Value = @"unanchored")] Unanchored = 11,

    [EnumMember(Value = @"unknown")] Unknown = 12
}