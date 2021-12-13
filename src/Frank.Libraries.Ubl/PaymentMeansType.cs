namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PaymentMeansType
{

    private IDType idField;

    private PaymentMeansCodeType paymentMeansCodeField;

    private PaymentDueDateType paymentDueDateField;

    private PaymentChannelCodeType paymentChannelCodeField;

    private InstructionIDType instructionIDField;

    private InstructionNoteType[] instructionNoteField;

    private PaymentIDType[] paymentIDField;

    private CardAccountType cardAccountField;

    private FinancialAccountType payerFinancialAccountField;

    private FinancialAccountType payeeFinancialAccountField;

    private CreditAccountType creditAccountField;

    private PaymentMandateType paymentMandateField;

    private TradeFinancingType tradeFinancingField;

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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentMeansCodeType PaymentMeansCode
    {
        get
        {
            return this.paymentMeansCodeField;
        }
        set
        {
            this.paymentMeansCodeField = value;
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
    public PaymentChannelCodeType PaymentChannelCode
    {
        get
        {
            return this.paymentChannelCodeField;
        }
        set
        {
            this.paymentChannelCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionIDType InstructionID
    {
        get
        {
            return this.instructionIDField;
        }
        set
        {
            this.instructionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionNoteType[] InstructionNote
    {
        get
        {
            return this.instructionNoteField;
        }
        set
        {
            this.instructionNoteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentIDType[] PaymentID
    {
        get
        {
            return this.paymentIDField;
        }
        set
        {
            this.paymentIDField = value;
        }
    }

    /// <remarks/>
    public CardAccountType CardAccount
    {
        get
        {
            return this.cardAccountField;
        }
        set
        {
            this.cardAccountField = value;
        }
    }

    /// <remarks/>
    public FinancialAccountType PayerFinancialAccount
    {
        get
        {
            return this.payerFinancialAccountField;
        }
        set
        {
            this.payerFinancialAccountField = value;
        }
    }

    /// <remarks/>
    public FinancialAccountType PayeeFinancialAccount
    {
        get
        {
            return this.payeeFinancialAccountField;
        }
        set
        {
            this.payeeFinancialAccountField = value;
        }
    }

    /// <remarks/>
    public CreditAccountType CreditAccount
    {
        get
        {
            return this.creditAccountField;
        }
        set
        {
            this.creditAccountField = value;
        }
    }

    /// <remarks/>
    public PaymentMandateType PaymentMandate
    {
        get
        {
            return this.paymentMandateField;
        }
        set
        {
            this.paymentMandateField = value;
        }
    }

    /// <remarks/>
    public TradeFinancingType TradeFinancing
    {
        get
        {
            return this.tradeFinancingField;
        }
        set
        {
            this.tradeFinancingField = value;
        }
    }
}