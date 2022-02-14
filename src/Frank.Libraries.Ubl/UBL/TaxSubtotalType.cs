namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TaxSubtotalType
{

    private TaxableAmountType taxableAmountField;

    private TaxAmountType taxAmountField;

    private CalculationSequenceNumericType calculationSequenceNumericField;

    private TransactionCurrencyTaxAmountType transactionCurrencyTaxAmountField;

    private PercentType1 percentField;

    private BaseUnitMeasureType baseUnitMeasureField;

    private PerUnitAmountType perUnitAmountField;

    private TierRangeType tierRangeField;

    private TierRatePercentType tierRatePercentField;

    private TaxCategoryType taxCategoryField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxableAmountType TaxableAmount
    {
        get
        {
            return this.taxableAmountField;
        }
        set
        {
            this.taxableAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxAmountType TaxAmount
    {
        get
        {
            return this.taxAmountField;
        }
        set
        {
            this.taxAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CalculationSequenceNumericType CalculationSequenceNumeric
    {
        get
        {
            return this.calculationSequenceNumericField;
        }
        set
        {
            this.calculationSequenceNumericField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransactionCurrencyTaxAmountType TransactionCurrencyTaxAmount
    {
        get
        {
            return this.transactionCurrencyTaxAmountField;
        }
        set
        {
            this.transactionCurrencyTaxAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PercentType1 Percent
    {
        get
        {
            return this.percentField;
        }
        set
        {
            this.percentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BaseUnitMeasureType BaseUnitMeasure
    {
        get
        {
            return this.baseUnitMeasureField;
        }
        set
        {
            this.baseUnitMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerUnitAmountType PerUnitAmount
    {
        get
        {
            return this.perUnitAmountField;
        }
        set
        {
            this.perUnitAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TierRangeType TierRange
    {
        get
        {
            return this.tierRangeField;
        }
        set
        {
            this.tierRangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TierRatePercentType TierRatePercent
    {
        get
        {
            return this.tierRatePercentField;
        }
        set
        {
            this.tierRatePercentField = value;
        }
    }

    /// <remarks/>
    public TaxCategoryType TaxCategory
    {
        get
        {
            return this.taxCategoryField;
        }
        set
        {
            this.taxCategoryField = value;
        }
    }
}