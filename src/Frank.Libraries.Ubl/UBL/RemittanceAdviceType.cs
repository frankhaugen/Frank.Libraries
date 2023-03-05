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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RemittanceAdvice-2")]
[XmlRoot("RemittanceAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RemittanceAdvice-2", IsNullable = false)]
public class RemittanceAdviceType
{
    private CustomerPartyType accountingCustomerPartyField;

    private SupplierPartyType accountingSupplierPartyField;

    private DocumentReferenceType[] additionalDocumentReferenceField;

    private BillingReferenceType billingReferenceField;

    private CopyIndicatorType copyIndicatorField;

    private CustomizationIDType customizationIDField;

    private DocumentCurrencyCodeType documentCurrencyCodeField;

    private IDType idField;

    private PeriodType[] invoicePeriodField;

    private InvoicingPartyReferenceType invoicingPartyReferenceField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private LineCountNumericType lineCountNumericField;

    private NoteType[] noteField;

    private PartyType payeePartyField;

    private PayerReferenceType payerReferenceField;

    private PaymentMeansType paymentMeansField;

    private PaymentOrderReferenceType paymentOrderReferenceField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private RemittanceAdviceLineType[] remittanceAdviceLineField;

    private SignatureType[] signatureField;

    private TaxTotalType[] taxTotalField;

    private TotalCreditAmountType totalCreditAmountField;

    private TotalDebitAmountType totalDebitAmountField;

    private TotalPaymentAmountType totalPaymentAmountField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlArrayItem("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get => uBLExtensionsField;
        set => uBLExtensionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get => uBLVersionIDField;
        set => uBLVersionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get => customizationIDField;
        set => customizationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get => profileIDField;
        set => profileIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get => profileExecutionIDField;
        set => profileExecutionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CopyIndicatorType CopyIndicator
    {
        get => copyIndicatorField;
        set => copyIndicatorField = value;
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
    public IssueDateType IssueDate
    {
        get => issueDateField;
        set => issueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get => issueTimeField;
        set => issueTimeField = value;
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
    public DocumentCurrencyCodeType DocumentCurrencyCode
    {
        get => documentCurrencyCodeField;
        set => documentCurrencyCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalDebitAmountType TotalDebitAmount
    {
        get => totalDebitAmountField;
        set => totalDebitAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalCreditAmountType TotalCreditAmount
    {
        get => totalCreditAmountField;
        set => totalCreditAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalPaymentAmountType TotalPaymentAmount
    {
        get => totalPaymentAmountField;
        set => totalPaymentAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentOrderReferenceType PaymentOrderReference
    {
        get => paymentOrderReferenceField;
        set => paymentOrderReferenceField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayerReferenceType PayerReference
    {
        get => payerReferenceField;
        set => payerReferenceField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InvoicingPartyReferenceType InvoicingPartyReference
    {
        get => invoicingPartyReferenceField;
        set => invoicingPartyReferenceField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineCountNumericType LineCountNumeric
    {
        get => lineCountNumericField;
        set => lineCountNumericField = value;
    }

    /// <remarks />
    [XmlElement("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] InvoicePeriod
    {
        get => invoicePeriodField;
        set => invoicePeriodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public BillingReferenceType BillingReference
    {
        get => billingReferenceField;
        set => billingReferenceField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] AdditionalDocumentReference
    {
        get => additionalDocumentReferenceField;
        set => additionalDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType AccountingCustomerParty
    {
        get => accountingCustomerPartyField;
        set => accountingCustomerPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SupplierPartyType AccountingSupplierParty
    {
        get => accountingSupplierPartyField;
        set => accountingSupplierPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType PayeeParty
    {
        get => payeePartyField;
        set => payeePartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PaymentMeansType PaymentMeans
    {
        get => paymentMeansField;
        set => paymentMeansField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    [XmlElement("RemittanceAdviceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public RemittanceAdviceLineType[] RemittanceAdviceLine
    {
        get => remittanceAdviceLineField;
        set => remittanceAdviceLineField = value;
    }
}