using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_fleet_okRole
{
    [EnumMember(Value = @"fleet_commander")]
    Fleet_commander = 0,

    [EnumMember(Value = @"squad_commander")]
    Squad_commander = 1,

    [EnumMember(Value = @"squad_member")] Squad_member = 2,

    [EnumMember(Value = @"wing_commander")]
    Wing_commander = 3
}