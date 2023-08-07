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
[XmlRoot("CompletedTask", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CompletedTaskType
{
    private AnnualAverageAmountType annualAverageAmountField;

    private DescriptionType[] descriptionField;

    private EvidenceSuppliedType[] evidenceSuppliedField;

    private PartyCapacityAmountType partyCapacityAmountField;

    private PeriodType periodField;

    private CustomerPartyType recipientCustomerPartyField;

    private TotalTaskAmountType totalTaskAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AnnualAverageAmountType AnnualAverageAmount
    {
        get => annualAverageAmountField;
        set => annualAverageAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTaskAmountType TotalTaskAmount
    {
        get => totalTaskAmountField;
        set => totalTaskAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PartyCapacityAmountType PartyCapacityAmount
    {
        get => partyCapacityAmountField;
        set => partyCapacityAmountField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("EvidenceSupplied")]
    public EvidenceSuppliedType[] EvidenceSupplied
    {
        get => evidenceSuppliedField;
        set => evidenceSuppliedField = value;
    }

    /// <remarks />
    public PeriodType Period
    {
        get => periodField;
        set => periodField = value;
    }

    /// <remarks />
    public CustomerPartyType RecipientCustomerParty
    {
        get => recipientCustomerPartyField;
        set => recipientCustomerPartyField = value;
    }
}