using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("TenderResult", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TenderResultType
{
    private AdvertisementAmountType advertisementAmountField;

    private AwardDateType awardDateField;

    private TenderedProjectType awardedTenderedProjectField;

    private AwardTimeType awardTimeField;

    private ContractType contractField;

    private PeriodType contractFormalizationPeriodField;

    private DescriptionType[] descriptionField;

    private HigherTenderAmountType higherTenderAmountField;

    private LowerTenderAmountType lowerTenderAmountField;

    private ReceivedElectronicTenderQuantityType receivedElectronicTenderQuantityField;

    private ReceivedForeignTenderQuantityType receivedForeignTenderQuantityField;

    private ReceivedTenderQuantityType receivedTenderQuantityField;

    private StartDateType startDateField;

    private SubcontractTermsType[] subcontractTermsField;

    private TenderResultCodeType tenderResultCodeField;

    private WinningPartyType[] winningPartyField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TenderResultCodeType TenderResultCode
    {
        get => tenderResultCodeField;
        set => tenderResultCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdvertisementAmountType AdvertisementAmount
    {
        get => advertisementAmountField;
        set => advertisementAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AwardDateType AwardDate
    {
        get => awardDateField;
        set => awardDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AwardTimeType AwardTime
    {
        get => awardTimeField;
        set => awardTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReceivedTenderQuantityType ReceivedTenderQuantity
    {
        get => receivedTenderQuantityField;
        set => receivedTenderQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LowerTenderAmountType LowerTenderAmount
    {
        get => lowerTenderAmountField;
        set => lowerTenderAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HigherTenderAmountType HigherTenderAmount
    {
        get => higherTenderAmountField;
        set => higherTenderAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public StartDateType StartDate
    {
        get => startDateField;
        set => startDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReceivedElectronicTenderQuantityType ReceivedElectronicTenderQuantity
    {
        get => receivedElectronicTenderQuantityField;
        set => receivedElectronicTenderQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReceivedForeignTenderQuantityType ReceivedForeignTenderQuantity
    {
        get => receivedForeignTenderQuantityField;
        set => receivedForeignTenderQuantityField = value;
    }

    /// <remarks />
    public ContractType Contract
    {
        get => contractField;
        set => contractField = value;
    }

    /// <remarks />
    public TenderedProjectType AwardedTenderedProject
    {
        get => awardedTenderedProjectField;
        set => awardedTenderedProjectField = value;
    }

    /// <remarks />
    public PeriodType ContractFormalizationPeriod
    {
        get => contractFormalizationPeriodField;
        set => contractFormalizationPeriodField = value;
    }

    /// <remarks />
    [XmlElement("SubcontractTerms")]
    public SubcontractTermsType[] SubcontractTerms
    {
        get => subcontractTermsField;
        set => subcontractTermsField = value;
    }

    /// <remarks />
    [XmlElement("WinningParty")]
    public WinningPartyType[] WinningParty
    {
        get => winningPartyField;
        set => winningPartyField = value;
    }
}