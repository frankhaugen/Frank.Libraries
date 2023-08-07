using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("ItemManagementProfile", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ItemManagementProfileType
{
    private PeriodType effectivePeriodField;

    private FrozenPeriodDaysNumericType frozenPeriodDaysNumericField;

    private ItemType itemField;

    private ItemLocationQuantityType itemLocationQuantityField;

    private MinimumInventoryQuantityType minimumInventoryQuantityField;

    private MultipleOrderQuantityType multipleOrderQuantityField;

    private OrderIntervalDaysNumericType orderIntervalDaysNumericField;

    private ReplenishmentOwnerDescriptionType[] replenishmentOwnerDescriptionField;

    private TargetInventoryQuantityType targetInventoryQuantityField;

    private TargetServicePercentType targetServicePercentField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FrozenPeriodDaysNumericType FrozenPeriodDaysNumeric
    {
        get => frozenPeriodDaysNumericField;
        set => frozenPeriodDaysNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumInventoryQuantityType MinimumInventoryQuantity
    {
        get => minimumInventoryQuantityField;
        set => minimumInventoryQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MultipleOrderQuantityType MultipleOrderQuantity
    {
        get => multipleOrderQuantityField;
        set => multipleOrderQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OrderIntervalDaysNumericType OrderIntervalDaysNumeric
    {
        get => orderIntervalDaysNumericField;
        set => orderIntervalDaysNumericField = value;
    }

    /// <remarks />
    [XmlElement("ReplenishmentOwnerDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReplenishmentOwnerDescriptionType[] ReplenishmentOwnerDescription
    {
        get => replenishmentOwnerDescriptionField;
        set => replenishmentOwnerDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TargetServicePercentType TargetServicePercent
    {
        get => targetServicePercentField;
        set => targetServicePercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TargetInventoryQuantityType TargetInventoryQuantity
    {
        get => targetInventoryQuantityField;
        set => targetInventoryQuantityField = value;
    }

    /// <remarks />
    public PeriodType EffectivePeriod
    {
        get => effectivePeriodField;
        set => effectivePeriodField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    public ItemLocationQuantityType ItemLocationQuantity
    {
        get => itemLocationQuantityField;
        set => itemLocationQuantityField = value;
    }
}