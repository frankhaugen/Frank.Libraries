using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("AwardingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AwardingTermsType
{
    private AwardingCriterionType[] awardingCriterionField;

    private BindingOnBuyerIndicatorType bindingOnBuyerIndicatorField;

    private DescriptionType[] descriptionField;

    private FollowupContractIndicatorType followupContractIndicatorField;

    private LowTendersDescriptionType[] lowTendersDescriptionField;

    private PaymentDescriptionType[] paymentDescriptionField;

    private PrizeDescriptionType[] prizeDescriptionField;

    private PrizeIndicatorType prizeIndicatorField;

    private TechnicalCommitteeDescriptionType[] technicalCommitteeDescriptionField;

    private PersonType[] technicalCommitteePersonField;

    private WeightingAlgorithmCodeType weightingAlgorithmCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WeightingAlgorithmCodeType WeightingAlgorithmCode
    {
        get => weightingAlgorithmCodeField;
        set => weightingAlgorithmCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("TechnicalCommitteeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TechnicalCommitteeDescriptionType[] TechnicalCommitteeDescription
    {
        get => technicalCommitteeDescriptionField;
        set => technicalCommitteeDescriptionField = value;
    }

    /// <remarks />
    [XmlElement("LowTendersDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LowTendersDescriptionType[] LowTendersDescription
    {
        get => lowTendersDescriptionField;
        set => lowTendersDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrizeIndicatorType PrizeIndicator
    {
        get => prizeIndicatorField;
        set => prizeIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("PrizeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrizeDescriptionType[] PrizeDescription
    {
        get => prizeDescriptionField;
        set => prizeDescriptionField = value;
    }

    /// <remarks />
    [XmlElement("PaymentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentDescriptionType[] PaymentDescription
    {
        get => paymentDescriptionField;
        set => paymentDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FollowupContractIndicatorType FollowupContractIndicator
    {
        get => followupContractIndicatorField;
        set => followupContractIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BindingOnBuyerIndicatorType BindingOnBuyerIndicator
    {
        get => bindingOnBuyerIndicatorField;
        set => bindingOnBuyerIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("AwardingCriterion")]
    public AwardingCriterionType[] AwardingCriterion
    {
        get => awardingCriterionField;
        set => awardingCriterionField = value;
    }

    /// <remarks />
    [XmlElement("TechnicalCommitteePerson")]
    public PersonType[] TechnicalCommitteePerson
    {
        get => technicalCommitteePersonField;
        set => technicalCommitteePersonField = value;
    }
}