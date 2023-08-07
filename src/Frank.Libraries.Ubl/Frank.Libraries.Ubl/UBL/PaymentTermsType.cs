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
[XmlRoot("BonusPaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PaymentTermsType
{
    private AmountType2 amountField;

    private ExchangeRateType exchangeRateField;

    private IDType idField;

    private InstallmentDueDateType installmentDueDateField;

    private InvoicingPartyReferenceType invoicingPartyReferenceField;

    private NoteType[] noteField;

    private PaymentDueDateType paymentDueDateField;

    private PaymentMeansIDType[] paymentMeansIDField;

    private PaymentPercentType paymentPercentField;

    private PaymentTermsDetailsURIType paymentTermsDetailsURIField;

    private PenaltyAmountType penaltyAmountField;

    private PeriodType penaltyPeriodField;

    private PenaltySurchargePercentType penaltySurchargePercentField;

    private PrepaidPaymentReferenceIDType prepaidPaymentReferenceIDField;

    private ReferenceEventCodeType referenceEventCodeField;

    private SettlementDiscountAmountType settlementDiscountAmountField;

    private SettlementDiscountPercentType settlementDiscountPercentField;

    private PeriodType settlementPeriodField;

    private PeriodType validityPeriodField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("PaymentMeansID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentMeansIDType[] PaymentMeansID
    {
        get => paymentMeansIDField;
        set => paymentMeansIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrepaidPaymentReferenceIDType PrepaidPaymentReferenceID
    {
        get => prepaidPaymentReferenceIDField;
        set => prepaidPaymentReferenceIDField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceEventCodeType ReferenceEventCode
    {
        get => referenceEventCodeField;
        set => referenceEventCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SettlementDiscountPercentType SettlementDiscountPercent
    {
        get => settlementDiscountPercentField;
        set => settlementDiscountPercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PenaltySurchargePercentType PenaltySurchargePercent
    {
        get => penaltySurchargePercentField;
        set => penaltySurchargePercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentPercentType PaymentPercent
    {
        get => paymentPercentField;
        set => paymentPercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AmountType2 Amount
    {
        get => amountField;
        set => amountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SettlementDiscountAmountType SettlementDiscountAmount
    {
        get => settlementDiscountAmountField;
        set => settlementDiscountAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PenaltyAmountType PenaltyAmount
    {
        get => penaltyAmountField;
        set => penaltyAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentTermsDetailsURIType PaymentTermsDetailsURI
    {
        get => paymentTermsDetailsURIField;
        set => paymentTermsDetailsURIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentDueDateType PaymentDueDate
    {
        get => paymentDueDateField;
        set => paymentDueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstallmentDueDateType InstallmentDueDate
    {
        get => installmentDueDateField;
        set => installmentDueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InvoicingPartyReferenceType InvoicingPartyReference
    {
        get => invoicingPartyReferenceField;
        set => invoicingPartyReferenceField = value;
    }

    /// <remarks />
    public PeriodType SettlementPeriod
    {
        get => settlementPeriodField;
        set => settlementPeriodField = value;
    }

    /// <remarks />
    public PeriodType PenaltyPeriod
    {
        get => penaltyPeriodField;
        set => penaltyPeriodField = value;
    }

    /// <remarks />
    public ExchangeRateType ExchangeRate
    {
        get => exchangeRateField;
        set => exchangeRateField = value;
    }

    /// <remarks />
    public PeriodType ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }
}