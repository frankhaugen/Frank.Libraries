using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_standings_200_okFrom_type
{
    [EnumMember(Value = @"agent")] Agent = 0,

    [EnumMember(Value = @"npc_corp")] Npc_corp = 1,

    [EnumMember(Value = @"faction")] Faction = 2
}