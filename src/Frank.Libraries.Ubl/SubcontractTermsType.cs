namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AllowedSubcontractTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class SubcontractTermsType
{

    private RateType1 rateField;

    private UnknownPriceIndicatorType unknownPriceIndicatorField;

    private DescriptionType[] descriptionField;

    private AmountType2 amountField;

    private SubcontractingConditionsCodeType subcontractingConditionsCodeField;

    private MaximumPercentType maximumPercentField;

    private MinimumPercentType minimumPercentField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RateType1 Rate
    {
        get
        {
            return this.rateField;
        }
        set
        {
            this.rateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UnknownPriceIndicatorType UnknownPriceIndicator
    {
        get
        {
            return this.unknownPriceIndicatorField;
        }
        set
        {
            this.unknownPriceIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
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
    public SubcontractingConditionsCodeType SubcontractingConditionsCode
    {
        get
        {
            return this.subcontractingConditionsCodeField;
        }
        set
        {
            this.subcontractingConditionsCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumPercentType MaximumPercent
    {
        get
        {
            return this.maximumPercentField;
        }
        set
        {
            this.maximumPercentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumPercentType MinimumPercent
    {
        get
        {
            return this.minimumPercentField;
        }
        set
        {
            this.minimumPercentField = value;
        }
    }
}