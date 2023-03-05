using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_calendar_200_okEvent_response
{
    [EnumMember(Value = @"declined")] Declined = 0,

    [EnumMember(Value = @"not_responded")] Not_responded = 1,

    [EnumMember(Value = @"accepted")] Accepted = 2,

    [EnumMember(Value = @"tentative")] Tentative = 3
}