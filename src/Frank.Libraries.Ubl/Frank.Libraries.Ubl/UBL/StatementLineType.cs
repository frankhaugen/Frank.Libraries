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
[XmlRoot("StatementLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class StatementLineType
{
    private CustomerPartyType accountingCustomerPartyField;

    private SupplierPartyType accountingSupplierPartyField;

    private AllowanceChargeType[] allowanceChargeField;

    private BalanceAmountType balanceAmountField;

    private BalanceBroughtForwardIndicatorType balanceBroughtForwardIndicatorField;

    private BillingReferenceType[] billingReferenceField;

    private CustomerPartyType buyerCustomerPartyField;

    private PaymentType[] collectedPaymentField;

    private CreditLineAmountType creditLineAmountField;

    private DebitLineAmountType debitLineAmountField;

    private DocumentReferenceType[] documentReferenceField;

    private ExchangeRateType exchangeRateField;

    private IDType idField;

    private PeriodType[] invoicePeriodField;

    private NoteType[] noteField;

    private CustomerPartyType originatorCustomerPartyField;

    private PartyType payeePartyField;

    private PaymentMeansType paymentMeansField;

    private PaymentPurposeCodeType paymentPurposeCodeField;

    private PaymentTermsType[] paymentTermsField;

    private SupplierPartyType sellerSupplierPartyField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
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
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BalanceBroughtForwardIndicatorType BalanceBroughtForwardIndicator
    {
        get => balanceBroughtForwardIndicatorField;
        set => balanceBroughtForwardIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DebitLineAmountType DebitLineAmount
    {
        get => debitLineAmountField;
        set => debitLineAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CreditLineAmountType CreditLineAmount
    {
        get => creditLineAmountField;
        set => creditLineAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BalanceAmountType BalanceAmount
    {
        get => balanceAmountField;
        set => balanceAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentPurposeCodeType PaymentPurposeCode
    {
        get => paymentPurposeCodeField;
        set => paymentPurposeCodeField = value;
    }

    /// <remarks />
    public PaymentMeansType PaymentMeans
    {
        get => paymentMeansField;
        set => paymentMeansField = value;
    }

    /// <remarks />
    [XmlElement("PaymentTerms")]
    public PaymentTermsType[] PaymentTerms
    {
        get => paymentTermsField;
        set => paymentTermsField = value;
    }

    /// <remarks />
    public CustomerPartyType BuyerCustomerParty
    {
        get => buyerCustomerPartyField;
        set => buyerCustomerPartyField = value;
    }

    /// <remarks />
    public SupplierPartyType SellerSupplierParty
    {
        get => sellerSupplierPartyField;
        set => sellerSupplierPartyField = value;
    }

    /// <remarks />
    public CustomerPartyType OriginatorCustomerParty
    {
        get => originatorCustomerPartyField;
        set => originatorCustomerPartyField = value;
    }

    /// <remarks />
    public CustomerPartyType AccountingCustomerParty
    {
        get => accountingCustomerPartyField;
        set => accountingCustomerPartyField = value;
    }

    /// <remarks />
    public SupplierPartyType AccountingSupplierParty
    {
        get => accountingSupplierPartyField;
        set => accountingSupplierPartyField = value;
    }

    /// <remarks />
    public PartyType PayeeParty
    {
        get => payeePartyField;
        set => payeePartyField = value;
    }

    /// <remarks />
    [XmlElement("InvoicePeriod")]
    public PeriodType[] InvoicePeriod
    {
        get => invoicePeriodField;
        set => invoicePeriodField = value;
    }

    /// <remarks />
    [XmlElement("BillingReference")]
    public BillingReferenceType[] BillingReference
    {
        get => billingReferenceField;
        set => billingReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public ExchangeRateType ExchangeRate
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
    [XmlElement("CollectedPayment")]
    public PaymentType[] CollectedPayment
    {
        get => collectedPaymentField;
        set => collectedPaymentField = value;
    }
}