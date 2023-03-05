using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[XmlInclude(typeof(VariantConstraintIndicatorType))]
[XmlInclude(typeof(UnknownPriceIndicatorType))]
[XmlInclude(typeof(ToOrderIndicatorType))]
[XmlInclude(typeof(ThirdPartyPayerIndicatorType))]
[XmlInclude(typeof(TaxIncludedIndicatorType))]
[XmlInclude(typeof(TaxEvidenceIndicatorType))]
[XmlInclude(typeof(StatusAvailableIndicatorType))]
[XmlInclude(typeof(SplitConsignmentIndicatorType))]
[XmlInclude(typeof(SpecialSecurityIndicatorType))]
[XmlInclude(typeof(SoleProprietorshipIndicatorType))]
[XmlInclude(typeof(ReturnableMaterialIndicatorType))]
[XmlInclude(typeof(ReturnabilityIndicatorType))]
[XmlInclude(typeof(RequiredCurriculaIndicatorType))]
[XmlInclude(typeof(RefrigerationOnIndicatorType))]
[XmlInclude(typeof(RefrigeratedIndicatorType))]
[XmlInclude(typeof(PublishAwardIndicatorType))]
[XmlInclude(typeof(PrizeIndicatorType))]
[XmlInclude(typeof(PricingUpdateRequestIndicatorType))]
[XmlInclude(typeof(PrepaidIndicatorType))]
[XmlInclude(typeof(PreCarriageIndicatorType))]
[XmlInclude(typeof(PowerIndicatorType))]
[XmlInclude(typeof(PartialDeliveryIndicatorType))]
[XmlInclude(typeof(OtherConditionsIndicatorType))]
[XmlInclude(typeof(OrderableIndicatorType))]
[XmlInclude(typeof(OptionalLineItemIndicatorType))]
[XmlInclude(typeof(OnCarriageIndicatorType))]
[XmlInclude(typeof(MarkCareIndicatorType))]
[XmlInclude(typeof(MarkAttentionIndicatorType))]
[XmlInclude(typeof(LivestockIndicatorType))]
[XmlInclude(typeof(LegalStatusIndicatorType))]
[XmlInclude(typeof(ItemUpdateRequestIndicatorType))]
[XmlInclude(typeof(IndicationIndicatorType))]
[XmlInclude(typeof(HumanFoodIndicatorType))]
[XmlInclude(typeof(HumanFoodApprovedIndicatorType))]
[XmlInclude(typeof(HazardousRiskIndicatorType))]
[XmlInclude(typeof(GovernmentAgreementConstraintIndicatorType))]
[XmlInclude(typeof(GeneralCargoIndicatorType))]
[XmlInclude(typeof(FullyPaidSharesIndicatorType))]
[XmlInclude(typeof(FrozenDocumentIndicatorType))]
[XmlInclude(typeof(FreeOfChargeIndicatorType))]
[XmlInclude(typeof(FollowupContractIndicatorType))]
[XmlInclude(typeof(DangerousGoodsApprovedIndicatorType))]
[XmlInclude(typeof(CustomsImportClassifiedIndicatorType))]
[XmlInclude(typeof(CopyIndicatorType))]
[XmlInclude(typeof(ContainerizedIndicatorType))]
[XmlInclude(typeof(ConsolidatableIndicatorType))]
[XmlInclude(typeof(CompletionIndicatorType))]
[XmlInclude(typeof(ChargeIndicatorType))]
[XmlInclude(typeof(CatalogueIndicatorType))]
[XmlInclude(typeof(CandidateReductionConstraintIndicatorType))]
[XmlInclude(typeof(BulkCargoIndicatorType))]
[XmlInclude(typeof(BindingOnBuyerIndicatorType))]
[XmlInclude(typeof(BasedOnConsensusIndicatorType))]
[XmlInclude(typeof(BalanceBroughtForwardIndicatorType))]
[XmlInclude(typeof(BackOrderAllowedIndicatorType))]
[XmlInclude(typeof(AuctionConstraintIndicatorType))]
[XmlInclude(typeof(AnimalFoodIndicatorType))]
[XmlInclude(typeof(AnimalFoodApprovedIndicatorType))]
[XmlInclude(typeof(AdValoremIndicatorType))]
[XmlInclude(typeof(AcceptedIndicatorType))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
public class IndicatorType
{
    private bool valueField;

    /// <remarks />
    [XmlText]
    public bool Value
    {
        get => valueField;
        set => valueField = value;
    }
}