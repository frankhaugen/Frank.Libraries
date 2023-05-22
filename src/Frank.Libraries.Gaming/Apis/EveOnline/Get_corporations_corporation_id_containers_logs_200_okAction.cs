using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_containers_logs_200_okAction
{
    [EnumMember(Value = @"add")] Add = 0,

    [EnumMember(Value = @"assemble")] Assemble = 1,

    [EnumMember(Value = @"configure")] Configure = 2,

    [EnumMember(Value = @"enter_password")]
    Enter_password = 3,

    [EnumMember(Value = @"lock")] Lock = 4,

    [EnumMember(Value = @"move")] Move = 5,

    [EnumMember(Value = @"repackage")] Repackage = 6,

    [EnumMember(Value = @"set_name")] Set_name = 7,

    [EnumMember(Value = @"set_password")] Set_password = 8,

    [EnumMember(Value = @"unlock")] Unlock = 9
}