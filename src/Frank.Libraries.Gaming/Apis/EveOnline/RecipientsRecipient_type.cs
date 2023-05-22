using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum RecipientsRecipient_type
{
    [EnumMember(Value = @"alliance")] Alliance = 0,

    [EnumMember(Value = @"character")] Character = 1,

    [EnumMember(Value = @"corporation")] Corporation = 2,

    [EnumMember(Value = @"mailing_list")] Mailing_list = 3
}