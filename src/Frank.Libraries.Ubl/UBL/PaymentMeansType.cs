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
[XmlRoot("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PaymentMeansType
{
    private CardAccountType cardAccountField;

    private CreditAccountType creditAccountField;

    private IDType idField;

    private InstructionIDType instructionIDField;

    private InstructionNoteType[] instructionNoteField;

    private FinancialAccountType payeeFinancialAccountField;

    private FinancialAccountType payerFinancialAccountField;

    private PaymentChannelCodeType paymentChannelCodeField;

    private PaymentDueDateType paymentDueDateField;

    private PaymentIDType[] paymentIDField;

    private PaymentMandateType paymentMandateField;

    private PaymentMeansCodeType paymentMeansCodeField;

    private TradeFinancingType tradeFinancingField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentMeansCodeType PaymentMeansCode
    {
        get => paymentMeansCodeField;
        set => paymentMeansCodeField = value;
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
    public PaymentChannelCodeType PaymentChannelCode
    {
        get => paymentChannelCodeField;
        set => paymentChannelCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionIDType InstructionID
    {
        get => instructionIDField;
        set => instructionIDField = value;
    }

    /// <remarks />
    [XmlElement("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionNoteType[] InstructionNote
    {
        get => instructionNoteField;
        set => instructionNoteField = value;
    }

    /// <remarks />
    [XmlElement("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentIDType[] PaymentID
    {
        get => paymentIDField;
        set => paymentIDField = value;
    }

    /// <remarks />
    public CardAccountType CardAccount
    {
        get => cardAccountField;
        set => cardAccountField = value;
    }

    /// <remarks />
    public FinancialAccountType PayerFinancialAccount
    {
        get => payerFinancialAccountField;
        set => payerFinancialAccountField = value;
    }

    /// <remarks />
    public FinancialAccountType PayeeFinancialAccount
    {
        get => payeeFinancialAccountField;
        set => payeeFinancialAccountField = value;
    }

    /// <remarks />
    public CreditAccountType CreditAccount
    {
        get => creditAccountField;
        set => creditAccountField = value;
    }

    /// <remarks />
    public PaymentMandateType PaymentMandate
    {
        get => paymentMandateField;
        set => paymentMandateField = value;
    }

    /// <remarks />
    public TradeFinancingType TradeFinancing
    {
        get => tradeFinancingField;
        set => tradeFinancingField = value;
    }
}