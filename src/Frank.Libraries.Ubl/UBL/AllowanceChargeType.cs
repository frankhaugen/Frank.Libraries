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
[XmlRoot("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AllowanceChargeType
{
    private AccountingCostCodeType accountingCostCodeField;

    private AccountingCostType accountingCostField;

    private AllowanceChargeReasonCodeType allowanceChargeReasonCodeField;

    private AllowanceChargeReasonType[] allowanceChargeReasonField;

    private AmountType2 amountField;

    private BaseAmountType baseAmountField;

    private ChargeIndicatorType chargeIndicatorField;

    private IDType idField;

    private MultiplierFactorNumericType multiplierFactorNumericField;

    private PaymentMeansType[] paymentMeansField;

    private PerUnitAmountType perUnitAmountField;

    private PrepaidIndicatorType prepaidIndicatorField;

    private SequenceNumericType sequenceNumericField;

    private TaxCategoryType[] taxCategoryField;

    private TaxTotalType taxTotalField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeIndicatorType ChargeIndicator
    {
        get => chargeIndicatorField;
        set => chargeIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AllowanceChargeReasonCodeType AllowanceChargeReasonCode
    {
        get => allowanceChargeReasonCodeField;
        set => allowanceChargeReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceChargeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AllowanceChargeReasonType[] AllowanceChargeReason
    {
        get => allowanceChargeReasonField;
        set => allowanceChargeReasonField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MultiplierFactorNumericType MultiplierFactorNumeric
    {
        get => multiplierFactorNumericField;
        set => multiplierFactorNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrepaidIndicatorType PrepaidIndicator
    {
        get => prepaidIndicatorField;
        set => prepaidIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumericType SequenceNumeric
    {
        get => sequenceNumericField;
        set => sequenceNumericField = value;
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
    public BaseAmountType BaseAmount
    {
        get => baseAmountField;
        set => baseAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostCodeType AccountingCostCode
    {
        get => accountingCostCodeField;
        set => accountingCostCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostType AccountingCost
    {
        get => accountingCostField;
        set => accountingCostField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerUnitAmountType PerUnitAmount
    {
        get => perUnitAmountField;
        set => perUnitAmountField = value;
    }

    /// <remarks />
    [XmlElement("TaxCategory")]
    public TaxCategoryType[] TaxCategory
    {
        get => taxCategoryField;
        set => taxCategoryField = value;
    }

    /// <remarks />
    public TaxTotalType TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    [XmlElement("PaymentMeans")]
    public PaymentMeansType[] PaymentMeans
    {
        get => paymentMeansField;
        set => paymentMeansField = value;
    }
}