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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TaxSubtotalType
{
    private BaseUnitMeasureType baseUnitMeasureField;

    private CalculationSequenceNumericType calculationSequenceNumericField;

    private PercentType1 percentField;

    private PerUnitAmountType perUnitAmountField;

    private TaxableAmountType taxableAmountField;

    private TaxAmountType taxAmountField;

    private TaxCategoryType taxCategoryField;

    private TierRangeType tierRangeField;

    private TierRatePercentType tierRatePercentField;

    private TransactionCurrencyTaxAmountType transactionCurrencyTaxAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxableAmountType TaxableAmount
    {
        get => taxableAmountField;
        set => taxableAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxAmountType TaxAmount
    {
        get => taxAmountField;
        set => taxAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CalculationSequenceNumericType CalculationSequenceNumeric
    {
        get => calculationSequenceNumericField;
        set => calculationSequenceNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransactionCurrencyTaxAmountType TransactionCurrencyTaxAmount
    {
        get => transactionCurrencyTaxAmountField;
        set => transactionCurrencyTaxAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PercentType1 Percent
    {
        get => percentField;
        set => percentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BaseUnitMeasureType BaseUnitMeasure
    {
        get => baseUnitMeasureField;
        set => baseUnitMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerUnitAmountType PerUnitAmount
    {
        get => perUnitAmountField;
        set => perUnitAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TierRangeType TierRange
    {
        get => tierRangeField;
        set => tierRangeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TierRatePercentType TierRatePercent
    {
        get => tierRatePercentField;
        set => tierRatePercentField = value;
    }

    /// <remarks />
    public TaxCategoryType TaxCategory
    {
        get => taxCategoryField;
        set => taxCategoryField = value;
    }
}