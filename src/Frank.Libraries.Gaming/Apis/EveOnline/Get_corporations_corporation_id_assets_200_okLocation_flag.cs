using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_assets_200_okLocation_flag
{
    [EnumMember(Value = @"AssetSafety")] AssetSafety = 0,

    [EnumMember(Value = @"AutoFit")] AutoFit = 1,

    [EnumMember(Value = @"Bonus")] Bonus = 2,

    [EnumMember(Value = @"Booster")] Booster = 3,

    [EnumMember(Value = @"BoosterBay")] BoosterBay = 4,

    [EnumMember(Value = @"Capsule")] Capsule = 5,

    [EnumMember(Value = @"Cargo")] Cargo = 6,

    [EnumMember(Value = @"CorpDeliveries")]
    CorpDeliveries = 7,

    [EnumMember(Value = @"CorpSAG1")] CorpSAG1 = 8,

    [EnumMember(Value = @"CorpSAG2")] CorpSAG2 = 9,

    [EnumMember(Value = @"CorpSAG3")] CorpSAG3 = 10,

    [EnumMember(Value = @"CorpSAG4")] CorpSAG4 = 11,

    [EnumMember(Value = @"CorpSAG5")] CorpSAG5 = 12,

    [EnumMember(Value = @"CorpSAG6")] CorpSAG6 = 13,

    [EnumMember(Value = @"CorpSAG7")] CorpSAG7 = 14,

    [EnumMember(Value = @"CrateLoot")] CrateLoot = 15,

    [EnumMember(Value = @"Deliveries")] Deliveries = 16,

    [EnumMember(Value = @"DroneBay")] DroneBay = 17,

    [EnumMember(Value = @"DustBattle")] DustBattle = 18,

    [EnumMember(Value = @"DustDatabank")] DustDatabank = 19,

    [EnumMember(Value = @"FighterBay")] FighterBay = 20,

    [EnumMember(Value = @"FighterTube0")] FighterTube0 = 21,

    [EnumMember(Value = @"FighterTube1")] FighterTube1 = 22,

    [EnumMember(Value = @"FighterTube2")] FighterTube2 = 23,

    [EnumMember(Value = @"FighterTube3")] FighterTube3 = 24,

    [EnumMember(Value = @"FighterTube4")] FighterTube4 = 25,

    [EnumMember(Value = @"FleetHangar")] FleetHangar = 26,

    [EnumMember(Value = @"FrigateEscapeBay")]
    FrigateEscapeBay = 27,

    [EnumMember(Value = @"Hangar")] Hangar = 28,

    [EnumMember(Value = @"HangarAll")] HangarAll = 29,

    [EnumMember(Value = @"HiSlot0")] HiSlot0 = 30,

    [EnumMember(Value = @"HiSlot1")] HiSlot1 = 31,

    [EnumMember(Value = @"HiSlot2")] HiSlot2 = 32,

    [EnumMember(Value = @"HiSlot3")] HiSlot3 = 33,

    [EnumMember(Value = @"HiSlot4")] HiSlot4 = 34,

    [EnumMember(Value = @"HiSlot5")] HiSlot5 = 35,

    [EnumMember(Value = @"HiSlot6")] HiSlot6 = 36,

    [EnumMember(Value = @"HiSlot7")] HiSlot7 = 37,

    [EnumMember(Value = @"HiddenModifiers")]
    HiddenModifiers = 38,

    [EnumMember(Value = @"Implant")] Implant = 39,

    [EnumMember(Value = @"Impounded")] Impounded = 40,

    [EnumMember(Value = @"JunkyardReprocessed")]
    JunkyardReprocessed = 41,

    [EnumMember(Value = @"JunkyardTrashed")]
    JunkyardTrashed = 42,

    [EnumMember(Value = @"LoSlot0")] LoSlot0 = 43,

    [EnumMember(Value = @"LoSlot1")] LoSlot1 = 44,

    [EnumMember(Value = @"LoSlot2")] LoSlot2 = 45,

    [EnumMember(Value = @"LoSlot3")] LoSlot3 = 46,

    [EnumMember(Value = @"LoSlot4")] LoSlot4 = 47,

    [EnumMember(Value = @"LoSlot5")] LoSlot5 = 48,

    [EnumMember(Value = @"LoSlot6")] LoSlot6 = 49,

    [EnumMember(Value = @"LoSlot7")] LoSlot7 = 50,

    [EnumMember(Value = @"Locked")] Locked = 51,

    [EnumMember(Value = @"MedSlot0")] MedSlot0 = 52,

    [EnumMember(Value = @"MedSlot1")] MedSlot1 = 53,

    [EnumMember(Value = @"MedSlot2")] MedSlot2 = 54,

    [EnumMember(Value = @"MedSlot3")] MedSlot3 = 55,

    [EnumMember(Value = @"MedSlot4")] MedSlot4 = 56,

    [EnumMember(Value = @"MedSlot5")] MedSlot5 = 57,

    [EnumMember(Value = @"MedSlot6")] MedSlot6 = 58,

    [EnumMember(Value = @"MedSlot7")] MedSlot7 = 59,

    [EnumMember(Value = @"OfficeFolder")] OfficeFolder = 60,

    [EnumMember(Value = @"Pilot")] Pilot = 61,

    [EnumMember(Value = @"PlanetSurface")] PlanetSurface = 62,

    [EnumMember(Value = @"QuafeBay")] QuafeBay = 63,

    [EnumMember(Value = @"QuantumCoreRoom")]
    QuantumCoreRoom = 64,

    [EnumMember(Value = @"Reward")] Reward = 65,

    [EnumMember(Value = @"RigSlot0")] RigSlot0 = 66,

    [EnumMember(Value = @"RigSlot1")] RigSlot1 = 67,

    [EnumMember(Value = @"RigSlot2")] RigSlot2 = 68,

    [EnumMember(Value = @"RigSlot3")] RigSlot3 = 69,

    [EnumMember(Value = @"RigSlot4")] RigSlot4 = 70,

    [EnumMember(Value = @"RigSlot5")] RigSlot5 = 71,

    [EnumMember(Value = @"RigSlot6")] RigSlot6 = 72,

    [EnumMember(Value = @"RigSlot7")] RigSlot7 = 73,

    [EnumMember(Value = @"SecondaryStorage")]
    SecondaryStorage = 74,

    [EnumMember(Value = @"ServiceSlot0")] ServiceSlot0 = 75,

    [EnumMember(Value = @"ServiceSlot1")] ServiceSlot1 = 76,

    [EnumMember(Value = @"ServiceSlot2")] ServiceSlot2 = 77,

    [EnumMember(Value = @"ServiceSlot3")] ServiceSlot3 = 78,

    [EnumMember(Value = @"ServiceSlot4")] ServiceSlot4 = 79,

    [EnumMember(Value = @"ServiceSlot5")] ServiceSlot5 = 80,

    [EnumMember(Value = @"ServiceSlot6")] ServiceSlot6 = 81,

    [EnumMember(Value = @"ServiceSlot7")] ServiceSlot7 = 82,

    [EnumMember(Value = @"ShipHangar")] ShipHangar = 83,

    [EnumMember(Value = @"ShipOffline")] ShipOffline = 84,

    [EnumMember(Value = @"Skill")] Skill = 85,

    [EnumMember(Value = @"SkillInTraining")]
    SkillInTraining = 86,

    [EnumMember(Value = @"SpecializedAmmoHold")]
    SpecializedAmmoHold = 87,

    [EnumMember(Value = @"SpecializedCommandCenterHold")]
    SpecializedCommandCenterHold = 88,

    [EnumMember(Value = @"SpecializedFuelBay")]
    SpecializedFuelBay = 89,

    [EnumMember(Value = @"SpecializedGasHold")]
    SpecializedGasHold = 90,

    [EnumMember(Value = @"SpecializedIndustrialShipHold")]
    SpecializedIndustrialShipHold = 91,

    [EnumMember(Value = @"SpecializedLargeShipHold")]
    SpecializedLargeShipHold = 92,

    [EnumMember(Value = @"SpecializedMaterialBay")]
    SpecializedMaterialBay = 93,

    [EnumMember(Value = @"SpecializedMediumShipHold")]
    SpecializedMediumShipHold = 94,

    [EnumMember(Value = @"SpecializedMineralHold")]
    SpecializedMineralHold = 95,

    [EnumMember(Value = @"SpecializedOreHold")]
    SpecializedOreHold = 96,

    [EnumMember(Value = @"SpecializedPlanetaryCommoditiesHold")]
    SpecializedPlanetaryCommoditiesHold = 97,

    [EnumMember(Value = @"SpecializedSalvageHold")]
    SpecializedSalvageHold = 98,

    [EnumMember(Value = @"SpecializedShipHold")]
    SpecializedShipHold = 99,

    [EnumMember(Value = @"SpecializedSmallShipHold")]
    SpecializedSmallShipHold = 100,

    [EnumMember(Value = @"StructureActive")]
    StructureActive = 101,

    [EnumMember(Value = @"StructureFuel")] StructureFuel = 102,

    [EnumMember(Value = @"StructureInactive")]
    StructureInactive = 103,

    [EnumMember(Value = @"StructureOffline")]
    StructureOffline = 104,

    [EnumMember(Value = @"SubSystemBay")] SubSystemBay = 105,

    [EnumMember(Value = @"SubSystemSlot0")]
    SubSystemSlot0 = 106,

    [EnumMember(Value = @"SubSystemSlot1")]
    SubSystemSlot1 = 107,

    [EnumMember(Value = @"SubSystemSlot2")]
    SubSystemSlot2 = 108,

    [EnumMember(Value = @"SubSystemSlot3")]
    SubSystemSlot3 = 109,

    [EnumMember(Value = @"SubSystemSlot4")]
    SubSystemSlot4 = 110,

    [EnumMember(Value = @"SubSystemSlot5")]
    SubSystemSlot5 = 111,

    [EnumMember(Value = @"SubSystemSlot6")]
    SubSystemSlot6 = 112,

    [EnumMember(Value = @"SubSystemSlot7")]
    SubSystemSlot7 = 113,

    [EnumMember(Value = @"Unlocked")] Unlocked = 114,

    [EnumMember(Value = @"Wallet")] Wallet = 115,

    [EnumMember(Value = @"Wardrobe")] Wardrobe = 116
}