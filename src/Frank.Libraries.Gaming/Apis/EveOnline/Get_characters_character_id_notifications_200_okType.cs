using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_characters_character_id_notifications_200_okType
{
    [EnumMember(Value = @"AcceptedAlly")] AcceptedAlly = 0,

    [EnumMember(Value = @"AcceptedSurrender")]
    AcceptedSurrender = 1,

    [EnumMember(Value = @"AgentRetiredTrigravian")]
    AgentRetiredTrigravian = 2,

    [EnumMember(Value = @"AllAnchoringMsg")]
    AllAnchoringMsg = 3,

    [EnumMember(Value = @"AllMaintenanceBillMsg")]
    AllMaintenanceBillMsg = 4,

    [EnumMember(Value = @"AllStrucInvulnerableMsg")]
    AllStrucInvulnerableMsg = 5,

    [EnumMember(Value = @"AllStructVulnerableMsg")]
    AllStructVulnerableMsg = 6,

    [EnumMember(Value = @"AllWarCorpJoinedAllianceMsg")]
    AllWarCorpJoinedAllianceMsg = 7,

    [EnumMember(Value = @"AllWarDeclaredMsg")]
    AllWarDeclaredMsg = 8,

    [EnumMember(Value = @"AllWarInvalidatedMsg")]
    AllWarInvalidatedMsg = 9,

    [EnumMember(Value = @"AllWarRetractedMsg")]
    AllWarRetractedMsg = 10,

    [EnumMember(Value = @"AllWarSurrenderMsg")]
    AllWarSurrenderMsg = 11,

    [EnumMember(Value = @"AllianceCapitalChanged")]
    AllianceCapitalChanged = 12,

    [EnumMember(Value = @"AllianceWarDeclaredV2")]
    AllianceWarDeclaredV2 = 13,

    [EnumMember(Value = @"AllyContractCancelled")]
    AllyContractCancelled = 14,

    [EnumMember(Value = @"AllyJoinedWarAggressorMsg")]
    AllyJoinedWarAggressorMsg = 15,

    [EnumMember(Value = @"AllyJoinedWarAllyMsg")]
    AllyJoinedWarAllyMsg = 16,

    [EnumMember(Value = @"AllyJoinedWarDefenderMsg")]
    AllyJoinedWarDefenderMsg = 17,

    [EnumMember(Value = @"BattlePunishFriendlyFire")]
    BattlePunishFriendlyFire = 18,

    [EnumMember(Value = @"BillOutOfMoneyMsg")]
    BillOutOfMoneyMsg = 19,

    [EnumMember(Value = @"BillPaidCorpAllMsg")]
    BillPaidCorpAllMsg = 20,

    [EnumMember(Value = @"BountyClaimMsg")]
    BountyClaimMsg = 21,

    [EnumMember(Value = @"BountyESSShared")]
    BountyESSShared = 22,

    [EnumMember(Value = @"BountyESSTaken")]
    BountyESSTaken = 23,

    [EnumMember(Value = @"BountyPlacedAlliance")]
    BountyPlacedAlliance = 24,

    [EnumMember(Value = @"BountyPlacedChar")]
    BountyPlacedChar = 25,

    [EnumMember(Value = @"BountyPlacedCorp")]
    BountyPlacedCorp = 26,

    [EnumMember(Value = @"BountyYourBountyClaimed")]
    BountyYourBountyClaimed = 27,

    [EnumMember(Value = @"BuddyConnectContactAdd")]
    BuddyConnectContactAdd = 28,

    [EnumMember(Value = @"CharAppAcceptMsg")]
    CharAppAcceptMsg = 29,

    [EnumMember(Value = @"CharAppRejectMsg")]
    CharAppRejectMsg = 30,

    [EnumMember(Value = @"CharAppWithdrawMsg")]
    CharAppWithdrawMsg = 31,

    [EnumMember(Value = @"CharLeftCorpMsg")]
    CharLeftCorpMsg = 32,

    [EnumMember(Value = @"CharMedalMsg")] CharMedalMsg = 33,

    [EnumMember(Value = @"CharTerminationMsg")]
    CharTerminationMsg = 34,

    [EnumMember(Value = @"CloneActivationMsg")]
    CloneActivationMsg = 35,

    [EnumMember(Value = @"CloneActivationMsg2")]
    CloneActivationMsg2 = 36,

    [EnumMember(Value = @"CloneMovedMsg")] CloneMovedMsg = 37,

    [EnumMember(Value = @"CloneRevokedMsg1")]
    CloneRevokedMsg1 = 38,

    [EnumMember(Value = @"CloneRevokedMsg2")]
    CloneRevokedMsg2 = 39,

    [EnumMember(Value = @"CombatOperationFinished")]
    CombatOperationFinished = 40,

    [EnumMember(Value = @"ContactAdd")] ContactAdd = 41,

    [EnumMember(Value = @"ContactEdit")] ContactEdit = 42,

    [EnumMember(Value = @"ContainerPasswordMsg")]
    ContainerPasswordMsg = 43,

    [EnumMember(Value = @"ContractRegionChangedToPochven")]
    ContractRegionChangedToPochven = 44,

    [EnumMember(Value = @"CorpAllBillMsg")]
    CorpAllBillMsg = 45,

    [EnumMember(Value = @"CorpAppAcceptMsg")]
    CorpAppAcceptMsg = 46,

    [EnumMember(Value = @"CorpAppInvitedMsg")]
    CorpAppInvitedMsg = 47,

    [EnumMember(Value = @"CorpAppNewMsg")] CorpAppNewMsg = 48,

    [EnumMember(Value = @"CorpAppRejectCustomMsg")]
    CorpAppRejectCustomMsg = 49,

    [EnumMember(Value = @"CorpAppRejectMsg")]
    CorpAppRejectMsg = 50,

    [EnumMember(Value = @"CorpBecameWarEligible")]
    CorpBecameWarEligible = 51,

    [EnumMember(Value = @"CorpDividendMsg")]
    CorpDividendMsg = 52,

    [EnumMember(Value = @"CorpFriendlyFireDisableTimerCompleted")]
    CorpFriendlyFireDisableTimerCompleted = 53,

    [EnumMember(Value = @"CorpFriendlyFireDisableTimerStarted")]
    CorpFriendlyFireDisableTimerStarted = 54,

    [EnumMember(Value = @"CorpFriendlyFireEnableTimerCompleted")]
    CorpFriendlyFireEnableTimerCompleted = 55,

    [EnumMember(Value = @"CorpFriendlyFireEnableTimerStarted")]
    CorpFriendlyFireEnableTimerStarted = 56,

    [EnumMember(Value = @"CorpKicked")] CorpKicked = 57,

    [EnumMember(Value = @"CorpLiquidationMsg")]
    CorpLiquidationMsg = 58,

    [EnumMember(Value = @"CorpNewCEOMsg")] CorpNewCEOMsg = 59,

    [EnumMember(Value = @"CorpNewsMsg")] CorpNewsMsg = 60,

    [EnumMember(Value = @"CorpNoLongerWarEligible")]
    CorpNoLongerWarEligible = 61,

    [EnumMember(Value = @"CorpOfficeExpirationMsg")]
    CorpOfficeExpirationMsg = 62,

    [EnumMember(Value = @"CorpStructLostMsg")]
    CorpStructLostMsg = 63,

    [EnumMember(Value = @"CorpTaxChangeMsg")]
    CorpTaxChangeMsg = 64,

    [EnumMember(Value = @"CorpVoteCEORevokedMsg")]
    CorpVoteCEORevokedMsg = 65,

    [EnumMember(Value = @"CorpVoteMsg")] CorpVoteMsg = 66,

    [EnumMember(Value = @"CorpWarDeclaredMsg")]
    CorpWarDeclaredMsg = 67,

    [EnumMember(Value = @"CorpWarDeclaredV2")]
    CorpWarDeclaredV2 = 68,

    [EnumMember(Value = @"CorpWarFightingLegalMsg")]
    CorpWarFightingLegalMsg = 69,

    [EnumMember(Value = @"CorpWarInvalidatedMsg")]
    CorpWarInvalidatedMsg = 70,

    [EnumMember(Value = @"CorpWarRetractedMsg")]
    CorpWarRetractedMsg = 71,

    [EnumMember(Value = @"CorpWarSurrenderMsg")]
    CorpWarSurrenderMsg = 72,

    [EnumMember(Value = @"CustomsMsg")] CustomsMsg = 73,

    [EnumMember(Value = @"DeclareWar")] DeclareWar = 74,

    [EnumMember(Value = @"DistrictAttacked")]
    DistrictAttacked = 75,

    [EnumMember(Value = @"DustAppAcceptedMsg")]
    DustAppAcceptedMsg = 76,

    [EnumMember(Value = @"ESSMainBankLink")]
    ESSMainBankLink = 77,

    [EnumMember(Value = @"EntosisCaptureStarted")]
    EntosisCaptureStarted = 78,

    [EnumMember(Value = @"ExpertSystemExpired")]
    ExpertSystemExpired = 79,

    [EnumMember(Value = @"ExpertSystemExpiryImminent")]
    ExpertSystemExpiryImminent = 80,

    [EnumMember(Value = @"FWAllianceKickMsg")]
    FWAllianceKickMsg = 81,

    [EnumMember(Value = @"FWAllianceWarningMsg")]
    FWAllianceWarningMsg = 82,

    [EnumMember(Value = @"FWCharKickMsg")] FWCharKickMsg = 83,

    [EnumMember(Value = @"FWCharRankGainMsg")]
    FWCharRankGainMsg = 84,

    [EnumMember(Value = @"FWCharRankLossMsg")]
    FWCharRankLossMsg = 85,

    [EnumMember(Value = @"FWCharWarningMsg")]
    FWCharWarningMsg = 86,

    [EnumMember(Value = @"FWCorpJoinMsg")] FWCorpJoinMsg = 87,

    [EnumMember(Value = @"FWCorpKickMsg")] FWCorpKickMsg = 88,

    [EnumMember(Value = @"FWCorpLeaveMsg")]
    FWCorpLeaveMsg = 89,

    [EnumMember(Value = @"FWCorpWarningMsg")]
    FWCorpWarningMsg = 90,

    [EnumMember(Value = @"FacWarCorpJoinRequestMsg")]
    FacWarCorpJoinRequestMsg = 91,

    [EnumMember(Value = @"FacWarCorpJoinWithdrawMsg")]
    FacWarCorpJoinWithdrawMsg = 92,

    [EnumMember(Value = @"FacWarCorpLeaveRequestMsg")]
    FacWarCorpLeaveRequestMsg = 93,

    [EnumMember(Value = @"FacWarCorpLeaveWithdrawMsg")]
    FacWarCorpLeaveWithdrawMsg = 94,

    [EnumMember(Value = @"FacWarLPDisqualifiedEvent")]
    FacWarLPDisqualifiedEvent = 95,

    [EnumMember(Value = @"FacWarLPDisqualifiedKill")]
    FacWarLPDisqualifiedKill = 96,

    [EnumMember(Value = @"FacWarLPPayoutEvent")]
    FacWarLPPayoutEvent = 97,

    [EnumMember(Value = @"FacWarLPPayoutKill")]
    FacWarLPPayoutKill = 98,

    [EnumMember(Value = @"GameTimeAdded")] GameTimeAdded = 99,

    [EnumMember(Value = @"GameTimeReceived")]
    GameTimeReceived = 100,

    [EnumMember(Value = @"GameTimeSent")] GameTimeSent = 101,

    [EnumMember(Value = @"GiftReceived")] GiftReceived = 102,

    [EnumMember(Value = @"IHubDestroyedByBillFailure")]
    IHubDestroyedByBillFailure = 103,

    [EnumMember(Value = @"IncursionCompletedMsg")]
    IncursionCompletedMsg = 104,

    [EnumMember(Value = @"IndustryOperationFinished")]
    IndustryOperationFinished = 105,

    [EnumMember(Value = @"IndustryTeamAuctionLost")]
    IndustryTeamAuctionLost = 106,

    [EnumMember(Value = @"IndustryTeamAuctionWon")]
    IndustryTeamAuctionWon = 107,

    [EnumMember(Value = @"InfrastructureHubBillAboutToExpire")]
    InfrastructureHubBillAboutToExpire = 108,

    [EnumMember(Value = @"InsuranceExpirationMsg")]
    InsuranceExpirationMsg = 109,

    [EnumMember(Value = @"InsuranceFirstShipMsg")]
    InsuranceFirstShipMsg = 110,

    [EnumMember(Value = @"InsuranceInvalidatedMsg")]
    InsuranceInvalidatedMsg = 111,

    [EnumMember(Value = @"InsuranceIssuedMsg")]
    InsuranceIssuedMsg = 112,

    [EnumMember(Value = @"InsurancePayoutMsg")]
    InsurancePayoutMsg = 113,

    [EnumMember(Value = @"InvasionCompletedMsg")]
    InvasionCompletedMsg = 114,

    [EnumMember(Value = @"InvasionSystemLogin")]
    InvasionSystemLogin = 115,

    [EnumMember(Value = @"InvasionSystemStart")]
    InvasionSystemStart = 116,

    [EnumMember(Value = @"JumpCloneDeletedMsg1")]
    JumpCloneDeletedMsg1 = 117,

    [EnumMember(Value = @"JumpCloneDeletedMsg2")]
    JumpCloneDeletedMsg2 = 118,

    [EnumMember(Value = @"KillReportFinalBlow")]
    KillReportFinalBlow = 119,

    [EnumMember(Value = @"KillReportVictim")]
    KillReportVictim = 120,

    [EnumMember(Value = @"KillRightAvailable")]
    KillRightAvailable = 121,

    [EnumMember(Value = @"KillRightAvailableOpen")]
    KillRightAvailableOpen = 122,

    [EnumMember(Value = @"KillRightEarned")]
    KillRightEarned = 123,

    [EnumMember(Value = @"KillRightUnavailable")]
    KillRightUnavailable = 124,

    [EnumMember(Value = @"KillRightUnavailableOpen")]
    KillRightUnavailableOpen = 125,

    [EnumMember(Value = @"KillRightUsed")] KillRightUsed = 126,

    [EnumMember(Value = @"LocateCharMsg")] LocateCharMsg = 127,

    [EnumMember(Value = @"MadeWarMutual")] MadeWarMutual = 128,

    [EnumMember(Value = @"MercOfferRetractedMsg")]
    MercOfferRetractedMsg = 129,

    [EnumMember(Value = @"MercOfferedNegotiationMsg")]
    MercOfferedNegotiationMsg = 130,

    [EnumMember(Value = @"MissionCanceledTriglavian")]
    MissionCanceledTriglavian = 131,

    [EnumMember(Value = @"MissionOfferExpirationMsg")]
    MissionOfferExpirationMsg = 132,

    [EnumMember(Value = @"MissionTimeoutMsg")]
    MissionTimeoutMsg = 133,

    [EnumMember(Value = @"MoonminingAutomaticFracture")]
    MoonminingAutomaticFracture = 134,

    [EnumMember(Value = @"MoonminingExtractionCancelled")]
    MoonminingExtractionCancelled = 135,

    [EnumMember(Value = @"MoonminingExtractionFinished")]
    MoonminingExtractionFinished = 136,

    [EnumMember(Value = @"MoonminingExtractionStarted")]
    MoonminingExtractionStarted = 137,

    [EnumMember(Value = @"MoonminingLaserFired")]
    MoonminingLaserFired = 138,

    [EnumMember(Value = @"MutualWarExpired")]
    MutualWarExpired = 139,

    [EnumMember(Value = @"MutualWarInviteAccepted")]
    MutualWarInviteAccepted = 140,

    [EnumMember(Value = @"MutualWarInviteRejected")]
    MutualWarInviteRejected = 141,

    [EnumMember(Value = @"MutualWarInviteSent")]
    MutualWarInviteSent = 142,

    [EnumMember(Value = @"NPCStandingsGained")]
    NPCStandingsGained = 143,

    [EnumMember(Value = @"NPCStandingsLost")]
    NPCStandingsLost = 144,

    [EnumMember(Value = @"OfferToAllyRetracted")]
    OfferToAllyRetracted = 145,

    [EnumMember(Value = @"OfferedSurrender")]
    OfferedSurrender = 146,

    [EnumMember(Value = @"OfferedToAlly")] OfferedToAlly = 147,

    [EnumMember(Value = @"OfficeLeaseCanceledInsufficientStandings")]
    OfficeLeaseCanceledInsufficientStandings = 148,

    [EnumMember(Value = @"OldLscMessages")]
    OldLscMessages = 149,

    [EnumMember(Value = @"OperationFinished")]
    OperationFinished = 150,

    [EnumMember(Value = @"OrbitalAttacked")]
    OrbitalAttacked = 151,

    [EnumMember(Value = @"OrbitalReinforced")]
    OrbitalReinforced = 152,

    [EnumMember(Value = @"OwnershipTransferred")]
    OwnershipTransferred = 153,

    [EnumMember(Value = @"RaffleCreated")] RaffleCreated = 154,

    [EnumMember(Value = @"RaffleExpired")] RaffleExpired = 155,

    [EnumMember(Value = @"RaffleFinished")]
    RaffleFinished = 156,

    [EnumMember(Value = @"ReimbursementMsg")]
    ReimbursementMsg = 157,

    [EnumMember(Value = @"ResearchMissionAvailableMsg")]
    ResearchMissionAvailableMsg = 158,

    [EnumMember(Value = @"RetractsWar")] RetractsWar = 159,

    [EnumMember(Value = @"SeasonalChallengeCompleted")]
    SeasonalChallengeCompleted = 160,

    [EnumMember(Value = @"SovAllClaimAquiredMsg")]
    SovAllClaimAquiredMsg = 161,

    [EnumMember(Value = @"SovAllClaimLostMsg")]
    SovAllClaimLostMsg = 162,

    [EnumMember(Value = @"SovCommandNodeEventStarted")]
    SovCommandNodeEventStarted = 163,

    [EnumMember(Value = @"SovCorpBillLateMsg")]
    SovCorpBillLateMsg = 164,

    [EnumMember(Value = @"SovCorpClaimFailMsg")]
    SovCorpClaimFailMsg = 165,

    [EnumMember(Value = @"SovDisruptorMsg")]
    SovDisruptorMsg = 166,

    [EnumMember(Value = @"SovStationEnteredFreeport")]
    SovStationEnteredFreeport = 167,

    [EnumMember(Value = @"SovStructureDestroyed")]
    SovStructureDestroyed = 168,

    [EnumMember(Value = @"SovStructureReinforced")]
    SovStructureReinforced = 169,

    [EnumMember(Value = @"SovStructureSelfDestructCancel")]
    SovStructureSelfDestructCancel = 170,

    [EnumMember(Value = @"SovStructureSelfDestructFinished")]
    SovStructureSelfDestructFinished = 171,

    [EnumMember(Value = @"SovStructureSelfDestructRequested")]
    SovStructureSelfDestructRequested = 172,

    [EnumMember(Value = @"SovereigntyIHDamageMsg")]
    SovereigntyIHDamageMsg = 173,

    [EnumMember(Value = @"SovereigntySBUDamageMsg")]
    SovereigntySBUDamageMsg = 174,

    [EnumMember(Value = @"SovereigntyTCUDamageMsg")]
    SovereigntyTCUDamageMsg = 175,

    [EnumMember(Value = @"StationAggressionMsg1")]
    StationAggressionMsg1 = 176,

    [EnumMember(Value = @"StationAggressionMsg2")]
    StationAggressionMsg2 = 177,

    [EnumMember(Value = @"StationConquerMsg")]
    StationConquerMsg = 178,

    [EnumMember(Value = @"StationServiceDisabled")]
    StationServiceDisabled = 179,

    [EnumMember(Value = @"StationServiceEnabled")]
    StationServiceEnabled = 180,

    [EnumMember(Value = @"StationStateChangeMsg")]
    StationStateChangeMsg = 181,

    [EnumMember(Value = @"StoryLineMissionAvailableMsg")]
    StoryLineMissionAvailableMsg = 182,

    [EnumMember(Value = @"StructureAnchoring")]
    StructureAnchoring = 183,

    [EnumMember(Value = @"StructureCourierContractChanged")]
    StructureCourierContractChanged = 184,

    [EnumMember(Value = @"StructureDestroyed")]
    StructureDestroyed = 185,

    [EnumMember(Value = @"StructureFuelAlert")]
    StructureFuelAlert = 186,

    [EnumMember(Value = @"StructureImpendingAbandonmentAssetsAtRisk")]
    StructureImpendingAbandonmentAssetsAtRisk = 187,

    [EnumMember(Value = @"StructureItemsDelivered")]
    StructureItemsDelivered = 188,

    [EnumMember(Value = @"StructureItemsMovedToSafety")]
    StructureItemsMovedToSafety = 189,

    [EnumMember(Value = @"StructureLostArmor")]
    StructureLostArmor = 190,

    [EnumMember(Value = @"StructureLostShields")]
    StructureLostShields = 191,

    [EnumMember(Value = @"StructureOnline")]
    StructureOnline = 192,

    [EnumMember(Value = @"StructureServicesOffline")]
    StructureServicesOffline = 193,

    [EnumMember(Value = @"StructureUnanchoring")]
    StructureUnanchoring = 194,

    [EnumMember(Value = @"StructureUnderAttack")]
    StructureUnderAttack = 195,

    [EnumMember(Value = @"StructureWentHighPower")]
    StructureWentHighPower = 196,

    [EnumMember(Value = @"StructureWentLowPower")]
    StructureWentLowPower = 197,

    [EnumMember(Value = @"StructuresJobsCancelled")]
    StructuresJobsCancelled = 198,

    [EnumMember(Value = @"StructuresJobsPaused")]
    StructuresJobsPaused = 199,

    [EnumMember(Value = @"StructuresReinforcementChanged")]
    StructuresReinforcementChanged = 200,

    [EnumMember(Value = @"TowerAlertMsg")] TowerAlertMsg = 201,

    [EnumMember(Value = @"TowerResourceAlertMsg")]
    TowerResourceAlertMsg = 202,

    [EnumMember(Value = @"TransactionReversalMsg")]
    TransactionReversalMsg = 203,

    [EnumMember(Value = @"TutorialMsg")] TutorialMsg = 204,

    [EnumMember(Value = @"WarAdopted ")] WarAdopted_ = 205,

    [EnumMember(Value = @"WarAllyInherited")]
    WarAllyInherited = 206,

    [EnumMember(Value = @"WarAllyOfferDeclinedMsg")]
    WarAllyOfferDeclinedMsg = 207,

    [EnumMember(Value = @"WarConcordInvalidates")]
    WarConcordInvalidates = 208,

    [EnumMember(Value = @"WarDeclared")] WarDeclared = 209,

    [EnumMember(Value = @"WarEndedHqSecurityDrop")]
    WarEndedHqSecurityDrop = 210,

    [EnumMember(Value = @"WarHQRemovedFromSpace")]
    WarHQRemovedFromSpace = 211,

    [EnumMember(Value = @"WarInherited")] WarInherited = 212,

    [EnumMember(Value = @"WarInvalid")] WarInvalid = 213,

    [EnumMember(Value = @"WarRetracted")] WarRetracted = 214,

    [EnumMember(Value = @"WarRetractedByConcord")]
    WarRetractedByConcord = 215,

    [EnumMember(Value = @"WarSurrenderDeclinedMsg")]
    WarSurrenderDeclinedMsg = 216,

    [EnumMember(Value = @"WarSurrenderOfferMsg")]
    WarSurrenderOfferMsg = 217
}