using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_contacts_200_okContact_type
{
    [EnumMember(Value = @"character")] Character = 0,

    [EnumMember(Value = @"corporation")] Corporation = 1,

    [EnumMember(Value = @"alliance")] Alliance = 2,

    [EnumMember(Value = @"faction")] Faction = 3
}