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
[XmlRoot("UtilityItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class UtilityItemType
{
    private ConsumptionTypeCodeType consumptionTypeCodeField;

    private ConsumptionTypeType consumptionTypeField;

    private ContractType contractField;

    private CurrentChargeTypeCodeType currentChargeTypeCodeField;

    private CurrentChargeTypeType currentChargeTypeField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private OneTimeChargeTypeCodeType oneTimeChargeTypeCodeField;

    private OneTimeChargeTypeType oneTimeChargeTypeField;

    private PackQuantityType packQuantityField;

    private PackSizeNumericType packSizeNumericField;

    private SubscriberIDType subscriberIDField;

    private SubscriberTypeCodeType subscriberTypeCodeField;

    private SubscriberTypeType subscriberTypeField;

    private TaxCategoryType taxCategoryField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubscriberIDType SubscriberID
    {
        get => subscriberIDField;
        set => subscriberIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubscriberTypeType SubscriberType
    {
        get => subscriberTypeField;
        set => subscriberTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubscriberTypeCodeType SubscriberTypeCode
    {
        get => subscriberTypeCodeField;
        set => subscriberTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackQuantityType PackQuantity
    {
        get => packQuantityField;
        set => packQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackSizeNumericType PackSizeNumeric
    {
        get => packSizeNumericField;
        set => packSizeNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeType ConsumptionType
    {
        get => consumptionTypeField;
        set => consumptionTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeCodeType ConsumptionTypeCode
    {
        get => consumptionTypeCodeField;
        set => consumptionTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CurrentChargeTypeType CurrentChargeType
    {
        get => currentChargeTypeField;
        set => currentChargeTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CurrentChargeTypeCodeType CurrentChargeTypeCode
    {
        get => currentChargeTypeCodeField;
        set => currentChargeTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OneTimeChargeTypeType OneTimeChargeType
    {
        get => oneTimeChargeTypeField;
        set => oneTimeChargeTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OneTimeChargeTypeCodeType OneTimeChargeTypeCode
    {
        get => oneTimeChargeTypeCodeField;
        set => oneTimeChargeTypeCodeField = value;
    }

    /// <remarks />
    public TaxCategoryType TaxCategory
    {
        get => taxCategoryField;
        set => taxCategoryField = value;
    }

    /// <remarks />
    public ContractType Contract
    {
        get => contractField;
        set => contractField = value;
    }
}