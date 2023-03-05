using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

/// <summary>
///     service string
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Services2
{
    [EnumMember(Value = @"bounty-missions")]
    BountyMissions = 0,

    [EnumMember(Value = @"assasination-missions")]
    AssasinationMissions = 1,

    [EnumMember(Value = @"courier-missions")]
    CourierMissions = 2,

    [EnumMember(Value = @"interbus")] Interbus = 3,

    [EnumMember(Value = @"reprocessing-plant")]
    ReprocessingPlant = 4,

    [EnumMember(Value = @"refinery")] Refinery = 5,

    [EnumMember(Value = @"market")] Market = 6,

    [EnumMember(Value = @"black-market")] BlackMarket = 7,

    [EnumMember(Value = @"stock-exchange")]
    StockExchange = 8,

    [EnumMember(Value = @"cloning")] Cloning = 9,

    [EnumMember(Value = @"surgery")] Surgery = 10,

    [EnumMember(Value = @"dna-therapy")] DnaTherapy = 11,

    [EnumMember(Value = @"repair-facilities")]
    RepairFacilities = 12,

    [EnumMember(Value = @"factory")] Factory = 13,

    [EnumMember(Value = @"labratory")] Labratory = 14,

    [EnumMember(Value = @"gambling")] Gambling = 15,

    [EnumMember(Value = @"fitting")] Fitting = 16,

    [EnumMember(Value = @"paintshop")] Paintshop = 17,

    [EnumMember(Value = @"news")] News = 18,

    [EnumMember(Value = @"storage")] Storage = 19,

    [EnumMember(Value = @"insurance")] Insurance = 20,

    [EnumMember(Value = @"docking")] Docking = 21,

    [EnumMember(Value = @"office-rental")] OfficeRental = 22,

    [EnumMember(Value = @"jump-clone-facility")]
    JumpCloneFacility = 23,

    [EnumMember(Value = @"loyalty-point-store")]
    LoyaltyPointStore = 24,

    [EnumMember(Value = @"navy-offices")] NavyOffices = 25,

    [EnumMember(Value = @"security-offices")]
    SecurityOffices = 26
}