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
[XmlRoot("TelecommunicationsService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TelecommunicationsServiceType
{
    private AllowanceChargeType[] allowanceChargeField;

    private CallBaseAmountType callBaseAmountField;

    private CallDateType callDateField;

    private DutyType1[] callDutyField;

    private CallExtensionAmountType callExtensionAmountField;

    private CallTimeType callTimeField;

    private CountryType countryField;

    private ExchangeRateType[] exchangeRateField;

    private IDType idField;

    private MovieTitleType movieTitleField;

    private PayPerViewType payPerViewField;

    private PriceType priceField;

    private QuantityType2 quantityField;

    private RoamingPartnerNameType roamingPartnerNameField;

    private ServiceNumberCalledType serviceNumberCalledField;

    private TaxTotalType[] taxTotalField;

    private TelecommunicationsServiceCallCodeType telecommunicationsServiceCallCodeField;

    private TelecommunicationsServiceCallType telecommunicationsServiceCallField;

    private TelecommunicationsServiceCategoryCodeType telecommunicationsServiceCategoryCodeField;

    private TelecommunicationsServiceCategoryType telecommunicationsServiceCategoryField;

    private DutyType1[] timeDutyField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CallDateType CallDate
    {
        get => callDateField;
        set => callDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CallTimeType CallTime
    {
        get => callTimeField;
        set => callTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ServiceNumberCalledType ServiceNumberCalled
    {
        get => serviceNumberCalledField;
        set => serviceNumberCalledField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsServiceCategoryType TelecommunicationsServiceCategory
    {
        get => telecommunicationsServiceCategoryField;
        set => telecommunicationsServiceCategoryField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsServiceCategoryCodeType TelecommunicationsServiceCategoryCode
    {
        get => telecommunicationsServiceCategoryCodeField;
        set => telecommunicationsServiceCategoryCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MovieTitleType MovieTitle
    {
        get => movieTitleField;
        set => movieTitleField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RoamingPartnerNameType RoamingPartnerName
    {
        get => roamingPartnerNameField;
        set => roamingPartnerNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayPerViewType PayPerView
    {
        get => payPerViewField;
        set => payPerViewField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsServiceCallType TelecommunicationsServiceCall
    {
        get => telecommunicationsServiceCallField;
        set => telecommunicationsServiceCallField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsServiceCallCodeType TelecommunicationsServiceCallCode
    {
        get => telecommunicationsServiceCallCodeField;
        set => telecommunicationsServiceCallCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CallBaseAmountType CallBaseAmount
    {
        get => callBaseAmountField;
        set => callBaseAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CallExtensionAmountType CallExtensionAmount
    {
        get => callExtensionAmountField;
        set => callExtensionAmountField = value;
    }

    /// <remarks />
    public PriceType Price
    {
        get => priceField;
        set => priceField = value;
    }

    /// <remarks />
    public CountryType Country
    {
        get => countryField;
        set => countryField = value;
    }

    /// <remarks />
    [XmlElement("ExchangeRate")]
    public ExchangeRateType[] ExchangeRate
    {
        get => exchangeRateField;
        set => exchangeRateField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    [XmlElement("CallDuty")]
    public DutyType1[] CallDuty
    {
        get => callDutyField;
        set => callDutyField = value;
    }

    /// <remarks />
    [XmlElement("TimeDuty")]
    public DutyType1[] TimeDuty
    {
        get => timeDutyField;
        set => timeDutyField = value;
    }
}