namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RemittanceAdviceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class RemittanceAdviceLineType
{

    private IDType idField;

    private NoteType[] noteField;

    private UUIDType uUIDField;

    private DebitLineAmountType debitLineAmountField;

    private CreditLineAmountType creditLineAmountField;

    private BalanceAmountType balanceAmountField;

    private PaymentPurposeCodeType paymentPurposeCodeField;

    private InvoicingPartyReferenceType invoicingPartyReferenceField;

    private SupplierPartyType accountingSupplierPartyField;

    private CustomerPartyType accountingCustomerPartyField;

    private CustomerPartyType buyerCustomerPartyField;

    private SupplierPartyType sellerSupplierPartyField;

    private CustomerPartyType originatorCustomerPartyField;

    private PartyType payeePartyField;

    private PeriodType[] invoicePeriodField;

    private BillingReferenceType[] billingReferenceField;

    private DocumentReferenceType[] documentReferenceField;

    private ExchangeRateType exchangeRateField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get
        {
            return this.uUIDField;
        }
        set
        {
            this.uUIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DebitLineAmountType DebitLineAmount
    {
        get
        {
            return this.debitLineAmountField;
        }
        set
        {
            this.debitLineAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CreditLineAmountType CreditLineAmount
    {
        get
        {
            return this.creditLineAmountField;
        }
        set
        {
            this.creditLineAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BalanceAmountType BalanceAmount
    {
        get
        {
            return this.balanceAmountField;
        }
        set
        {
            this.balanceAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentPurposeCodeType PaymentPurposeCode
    {
        get
        {
            return this.paymentPurposeCodeField;
        }
        set
        {
            this.paymentPurposeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InvoicingPartyReferenceType InvoicingPartyReference
    {
        get
        {
            return this.invoicingPartyReferenceField;
        }
        set
        {
            this.invoicingPartyReferenceField = value;
        }
    }

    /// <remarks/>
    public SupplierPartyType AccountingSupplierParty
    {
        get
        {
            return this.accountingSupplierPartyField;
        }
        set
        {
            this.accountingSupplierPartyField = value;
        }
    }

    /// <remarks/>
    public CustomerPartyType AccountingCustomerParty
    {
        get
        {
            return this.accountingCustomerPartyField;
        }
        set
        {
            this.accountingCustomerPartyField = value;
        }
    }

    /// <remarks/>
    public CustomerPartyType BuyerCustomerParty
    {
        get
        {
            return this.buyerCustomerPartyField;
        }
        set
        {
            this.buyerCustomerPartyField = value;
        }
    }

    /// <remarks/>
    public SupplierPartyType SellerSupplierParty
    {
        get
        {
            return this.sellerSupplierPartyField;
        }
        set
        {
            this.sellerSupplierPartyField = value;
        }
    }

    /// <remarks/>
    public CustomerPartyType OriginatorCustomerParty
    {
        get
        {
            return this.originatorCustomerPartyField;
        }
        set
        {
            this.originatorCustomerPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType PayeeParty
    {
        get
        {
            return this.payeePartyField;
        }
        set
        {
            this.payeePartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod")]
    public PeriodType[] InvoicePeriod
    {
        get
        {
            return this.invoicePeriodField;
        }
        set
        {
            this.invoicePeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
    public BillingReferenceType[] BillingReference
    {
        get
        {
            return this.billingReferenceField;
        }
        set
        {
            this.billingReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get
        {
            return this.documentReferenceField;
        }
        set
        {
            this.documentReferenceField = value;
        }
    }

    /// <remarks/>
    public ExchangeRateType ExchangeRate
    {
        get
        {
            return this.exchangeRateField;
        }
        set
        {
            this.exchangeRateField = value;
        }
    }
}