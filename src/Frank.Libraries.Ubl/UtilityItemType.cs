namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("UtilityItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class UtilityItemType
{

    private IDType idField;

    private SubscriberIDType subscriberIDField;

    private SubscriberTypeType subscriberTypeField;

    private SubscriberTypeCodeType subscriberTypeCodeField;

    private DescriptionType[] descriptionField;

    private PackQuantityType packQuantityField;

    private PackSizeNumericType packSizeNumericField;

    private ConsumptionTypeType consumptionTypeField;

    private ConsumptionTypeCodeType consumptionTypeCodeField;

    private CurrentChargeTypeType currentChargeTypeField;

    private CurrentChargeTypeCodeType currentChargeTypeCodeField;

    private OneTimeChargeTypeType oneTimeChargeTypeField;

    private OneTimeChargeTypeCodeType oneTimeChargeTypeCodeField;

    private TaxCategoryType taxCategoryField;

    private ContractType contractField;

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
    public SubscriberIDType SubscriberID
    {
        get
        {
            return this.subscriberIDField;
        }
        set
        {
            this.subscriberIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubscriberTypeType SubscriberType
    {
        get
        {
            return this.subscriberTypeField;
        }
        set
        {
            this.subscriberTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubscriberTypeCodeType SubscriberTypeCode
    {
        get
        {
            return this.subscriberTypeCodeField;
        }
        set
        {
            this.subscriberTypeCodeField = value;
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
    public PackQuantityType PackQuantity
    {
        get
        {
            return this.packQuantityField;
        }
        set
        {
            this.packQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackSizeNumericType PackSizeNumeric
    {
        get
        {
            return this.packSizeNumericField;
        }
        set
        {
            this.packSizeNumericField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeType ConsumptionType
    {
        get
        {
            return this.consumptionTypeField;
        }
        set
        {
            this.consumptionTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeCodeType ConsumptionTypeCode
    {
        get
        {
            return this.consumptionTypeCodeField;
        }
        set
        {
            this.consumptionTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CurrentChargeTypeType CurrentChargeType
    {
        get
        {
            return this.currentChargeTypeField;
        }
        set
        {
            this.currentChargeTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CurrentChargeTypeCodeType CurrentChargeTypeCode
    {
        get
        {
            return this.currentChargeTypeCodeField;
        }
        set
        {
            this.currentChargeTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OneTimeChargeTypeType OneTimeChargeType
    {
        get
        {
            return this.oneTimeChargeTypeField;
        }
        set
        {
            this.oneTimeChargeTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OneTimeChargeTypeCodeType OneTimeChargeTypeCode
    {
        get
        {
            return this.oneTimeChargeTypeCodeField;
        }
        set
        {
            this.oneTimeChargeTypeCodeField = value;
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

    /// <remarks/>
    public ContractType Contract
    {
        get
        {
            return this.contractField;
        }
        set
        {
            this.contractField = value;
        }
    }
}