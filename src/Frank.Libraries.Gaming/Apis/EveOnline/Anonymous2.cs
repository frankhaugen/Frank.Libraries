using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Anonymous2
{
    [EnumMember(Value = @"agent")] Agent = 0,

    [EnumMember(Value = @"alliance")] Alliance = 1,

    [EnumMember(Value = @"character")] Character = 2,

    [EnumMember(Value = @"constellation")] Constellation = 3,

    [EnumMember(Value = @"corporation")] Corporation = 4,

    [EnumMember(Value = @"faction")] Faction = 5,

    [EnumMember(Value = @"inventory_type")]
    Inventory_type = 6,

    [EnumMember(Value = @"region")] Region = 7,

    [EnumMember(Value = @"solar_system")] Solar_system = 8,

    [EnumMember(Value = @"station")] Station = 9
}