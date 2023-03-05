using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_starbases_starbase_id_okOnline
{
    [EnumMember(Value = @"alliance_member")]
    Alliance_member = 0,

    [EnumMember(Value = @"config_starbase_equipment_role")]
    Config_starbase_equipment_role = 1,

    [EnumMember(Value = @"corporation_member")]
    Corporation_member = 2,

    [EnumMember(Value = @"starbase_fuel_technician_role")]
    Starbase_fuel_technician_role = 3
}