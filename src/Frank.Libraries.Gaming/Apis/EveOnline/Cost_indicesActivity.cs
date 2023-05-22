using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Cost_indicesActivity
{
    [EnumMember(Value = @"copying")] Copying = 0,

    [EnumMember(Value = @"duplicating")] Duplicating = 1,

    [EnumMember(Value = @"invention")] Invention = 2,

    [EnumMember(Value = @"manufacturing")] Manufacturing = 3,

    [EnumMember(Value = @"none")] None = 4,

    [EnumMember(Value = @"reaction")] Reaction = 5,

    [EnumMember(Value = @"researching_material_efficiency")]
    Researching_material_efficiency = 6,

    [EnumMember(Value = @"researching_technology")]
    Researching_technology = 7,

    [EnumMember(Value = @"researching_time_efficiency")]
    Researching_time_efficiency = 8,

    [EnumMember(Value = @"reverse_engineering")]
    Reverse_engineering = 9
}