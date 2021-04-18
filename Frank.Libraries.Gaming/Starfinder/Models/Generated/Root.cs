using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated{ 

    public class Root
    {
        [JsonPropertyName("ablativeArmorId")]
        public string AblativeArmorId { get; set; }

        [JsonPropertyName("ablativeArmorByPosition")]
        public AblativeArmorByPosition AblativeArmorByPosition { get; set; }

        [JsonPropertyName("antiHackingSystemsId")]
        public string AntiHackingSystemsId { get; set; }

        [JsonPropertyName("antiPersonnelWeaponId")]
        public string AntiPersonnelWeaponId { get; set; }

        [JsonPropertyName("armorId")]
        public string ArmorId { get; set; }

        [JsonPropertyName("armorMaterialId")]
        public string ArmorMaterialId { get; set; }

        [JsonPropertyName("computerCountermeasures")]
        public ComputerCountermeasures ComputerCountermeasures { get; set; }

        [JsonPropertyName("computerId")]
        public string ComputerId { get; set; }

        [JsonPropertyName("crewQuartersId")]
        public string CrewQuartersId { get; set; }

        [JsonPropertyName("crewSkills")]
        public CrewSkills CrewSkills { get; set; }

        [JsonPropertyName("ctTim")]
        public int CtTim { get; set; }

        [JsonPropertyName("ctTimAll")]
        public int CtTimAll { get; set; }

        [JsonPropertyName("customFrameBaseId")]
        public string CustomFrameBaseId { get; set; }

        [JsonPropertyName("customComponents")]
        public List<object> CustomComponents { get; } = new List<object>();

        [JsonPropertyName("dedicatedComputerId")]
        public string DedicatedComputerId { get; set; }

        [JsonPropertyName("defensiveCountermeasuresId")]
        public string DefensiveCountermeasuresId { get; set; }

        [JsonPropertyName("defensiveCountermeasuresMaterialId")]
        public string DefensiveCountermeasuresMaterialId { get; set; }

        [JsonPropertyName("deflectorShieldId")]
        public string DeflectorShieldId { get; set; }

        [JsonPropertyName("driftEngineId")]
        public string DriftEngineId { get; set; }

        [JsonPropertyName("expansionBayIds")]
        public List<string> ExpansionBayIds { get; } = new List<string>();

        [JsonPropertyName("fortifiedHullId")]
        public string FortifiedHullId { get; set; }

        [JsonPropertyName("frameId")]
        public string FrameId { get; set; }

        [JsonPropertyName("hasAlgalShielding")]
        public int HasAlgalShielding { get; set; }

        [JsonPropertyName("hasAutoDestruct")]
        public int HasAutoDestruct { get; set; }

        [JsonPropertyName("hasBiometricLocks")]
        public int HasBiometricLocks { get; set; }

        [JsonPropertyName("hasColonyShipFramework")]
        public int HasColonyShipFramework { get; set; }

        [JsonPropertyName("hasConsciousnessUplink")]
        public int HasConsciousnessUplink { get; set; }

        [JsonPropertyName("hasCrew")]
        public bool HasCrew { get; set; }

        [JsonPropertyName("hasDataNet")]
        public int HasDataNet { get; set; }

        [JsonPropertyName("hasEmergencyAccelerator")]
        public int HasEmergencyAccelerator { get; set; }

        [JsonPropertyName("hasHiveJoining")]
        public int HasHiveJoining { get; set; }

        [JsonPropertyName("hasHolographicMantle")]
        public int HasHolographicMantle { get; set; }

        [JsonPropertyName("hasPowersap")]
        public int HasPowersap { get; set; }

        [JsonPropertyName("hasReconfigurationSystem")]
        public int HasReconfigurationSystem { get; set; }

        [JsonPropertyName("hasRootSystem")]
        public int HasRootSystem { get; set; }

        [JsonPropertyName("hasSelfDestructSystem")]
        public int HasSelfDestructSystem { get; set; }

        [JsonPropertyName("hasSpaceStationFramework")]
        public int HasSpaceStationFramework { get; set; }

        [JsonPropertyName("isSetDefaultCrewSkillValues")]
        public int IsSetDefaultCrewSkillValues { get; set; }

        [JsonPropertyName("isUseStrictRules")]
        public bool IsUseStrictRules { get; set; }

        [JsonPropertyName("powerCoreIds")]
        public List<string> PowerCoreIds { get; } = new List<string>();

        [JsonPropertyName("powerCoreSpecialMaterials")]
        public List<string> PowerCoreSpecialMaterials { get; } = new List<string>();

        [JsonPropertyName("ctNetworkNodes")]
        public int CtNetworkNodes { get; set; }

        [JsonPropertyName("reinforcedBulkheadId")]
        public string ReinforcedBulkheadId { get; set; }

        [JsonPropertyName("roboticAppendageId")]
        public string RoboticAppendageId { get; set; }

        [JsonPropertyName("secondaryComputerId")]
        public string SecondaryComputerId { get; set; }

        [JsonPropertyName("sensorsId")]
        public string SensorsId { get; set; }

        [JsonPropertyName("sensorsMaterialId")]
        public string SensorsMaterialId { get; set; }

        [JsonPropertyName("shieldType")]
        public string ShieldType { get; set; }

        [JsonPropertyName("shieldsByPosition")]
        public ShieldsByPosition ShieldsByPosition { get; set; }

        [JsonPropertyName("shieldsId")]
        public string ShieldsId { get; set; }

        [JsonPropertyName("shipConcept")]
        public string ShipConcept { get; set; }

        [JsonPropertyName("shipName")]
        public string ShipName { get; set; }

        [JsonPropertyName("sources")]
        public Sources Sources { get; set; }

        [JsonPropertyName("thrustersId")]
        public string ThrustersId { get; set; }

        [JsonPropertyName("thrustersMaterialId")]
        public string ThrustersMaterialId { get; set; }

        [JsonPropertyName("thrustersBoosterId")]
        public string ThrustersBoosterId { get; set; }

        [JsonPropertyName("thrustersBoosterMaterialId")]
        public string ThrustersBoosterMaterialId { get; set; }

        [JsonPropertyName("tierId")]
        public string TierId { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("viId")]
        public string ViId { get; set; }

        [JsonPropertyName("viHoloProjectorId")]
        public string ViHoloProjectorId { get; set; }

        [JsonPropertyName("viSkillExpanderId")]
        public string ViSkillExpanderId { get; set; }

        [JsonPropertyName("weaponMounts")]
        public WeaponMounts WeaponMounts { get; set; }
    }

}