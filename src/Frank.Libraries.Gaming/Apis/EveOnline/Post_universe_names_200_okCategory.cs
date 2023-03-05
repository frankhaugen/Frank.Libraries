using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Post_universe_names_200_okCategory
{
    [EnumMember(Value = @"alliance")] Alliance = 0,

    [EnumMember(Value = @"character")] Character = 1,

    [EnumMember(Value = @"constellation")] Constellation = 2,

    [EnumMember(Value = @"corporation")] Corporation = 3,

    [EnumMember(Value = @"inventory_type")]
    Inventory_type = 4,

    [EnumMember(Value = @"region")] Region = 5,

    [EnumMember(Value = @"solar_system")] Solar_system = 6,

    [EnumMember(Value = @"station")] Station = 7,

    [EnumMember(Value = @"faction")] Faction = 8
}