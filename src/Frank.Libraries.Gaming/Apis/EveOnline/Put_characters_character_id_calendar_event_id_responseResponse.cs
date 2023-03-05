using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Put_characters_character_id_calendar_event_id_responseResponse
{
    [EnumMember(Value = @"accepted")] Accepted = 0,

    [EnumMember(Value = @"declined")] Declined = 1,

    [EnumMember(Value = @"tentative")] Tentative = 2
}