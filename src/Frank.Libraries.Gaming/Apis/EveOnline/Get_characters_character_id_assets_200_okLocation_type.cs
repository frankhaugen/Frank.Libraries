using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_assets_200_okLocation_type
{
    [EnumMember(Value = @"station")] Station = 0,

    [EnumMember(Value = @"solar_system")] Solar_system = 1,

    [EnumMember(Value = @"item")] Item = 2,

    [EnumMember(Value = @"other")] Other = 3
}