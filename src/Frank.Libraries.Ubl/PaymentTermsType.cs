namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("BonusPaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PaymentTermsType
{

    private IDType idField;

    private PaymentMeansIDType[] paymentMeansIDField;

    private PrepaidPaymentReferenceIDType prepaidPaymentReferenceIDField;

    private NoteType[] noteField;

    private ReferenceEventCodeType referenceEventCodeField;

    private SettlementDiscountPercentType settlementDiscountPercentField;

    private PenaltySurchargePercentType penaltySurchargePercentField;

    private PaymentPercentType paymentPercentField;

    private AmountType2 amountField;

    private SettlementDiscountAmountType settlementDiscountAmountField;

    private PenaltyAmountType penaltyAmountField;

    private PaymentTermsDetailsURIType paymentTermsDetailsURIField;

    private PaymentDueDateType paymentDueDateField;

    private InstallmentDueDateType installmentDueDateField;

    private InvoicingPartyReferenceType invoicingPartyReferenceField;

    private PeriodType settlementPeriodField;

    private PeriodType penaltyPeriodField;

    private ExchangeRateType exchangeRateField;

    private PeriodType validityPeriodField;

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
    [System.Xml.Serialization.XmlElementAttribute("PaymentMeansID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentMeansIDType[] PaymentMeansID
    {
        get
        {
            return this.paymentMeansIDField;
        }
        set
        {
            this.paymentMeansIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrepaidPaymentReferenceIDType PrepaidPaymentReferenceID
    {
        get
        {
            return this.prepaidPaymentReferenceIDField;
        }
        set
        {
            this.prepaidPaymentReferenceIDField = value;
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
    public ReferenceEventCodeType ReferenceEventCode
    {
        get
        {
            return this.referenceEventCodeField;
        }
        set
        {
            this.referenceEventCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SettlementDiscountPercentType SettlementDiscountPercent
    {
        get
        {
            return this.settlementDiscountPercentField;
        }
        set
        {
            this.settlementDiscountPercentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PenaltySurchargePercentType PenaltySurchargePercent
    {
        get
        {
            return this.penaltySurchargePercentField;
        }
        set
        {
            this.penaltySurchargePercentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentPercentType PaymentPercent
    {
        get
        {
            return this.paymentPercentField;
        }
        set
        {
            this.paymentPercentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AmountType2 Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SettlementDiscountAmountType SettlementDiscountAmount
    {
        get
        {
            return this.settlementDiscountAmountField;
        }
        set
        {
            this.settlementDiscountAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PenaltyAmountType PenaltyAmount
    {
        get
        {
            return this.penaltyAmountField;
        }
        set
        {
            this.penaltyAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentTermsDetailsURIType PaymentTermsDetailsURI
    {
        get
        {
            return this.paymentTermsDetailsURIField;
        }
        set
        {
            this.paymentTermsDetailsURIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentDueDateType PaymentDueDate
    {
        get
        {
            return this.paymentDueDateField;
        }
        set
        {
            this.paymentDueDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstallmentDueDateType InstallmentDueDate
    {
        get
        {
            return this.installmentDueDateField;
        }
        set
        {
            this.installmentDueDateField = value;
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
    public PeriodType SettlementPeriod
    {
        get
        {
            return this.settlementPeriodField;
        }
        set
        {
            this.settlementPeriodField = value;
        }
    }

    /// <remarks/>
    public PeriodType PenaltyPeriod
    {
        get
        {
            return this.penaltyPeriodField;
        }
        set
        {
            this.penaltyPeriodField = value;
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

    /// <remarks/>
    public PeriodType ValidityPeriod
    {
        get
        {
            return this.validityPeriodField;
        }
        set
        {
            this.validityPeriodField = value;
        }
    }
}