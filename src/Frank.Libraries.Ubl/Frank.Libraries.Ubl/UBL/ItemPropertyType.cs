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
[XmlRoot("AdditionalItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ItemPropertyType
{
    private IDType idField;

    private ImportanceCodeType importanceCodeField;

    private ItemPropertyGroupType[] itemPropertyGroupField;

    private ItemPropertyRangeType itemPropertyRangeField;

    private ListValueType[] listValueField;

    private NameCodeType nameCodeField;

    private NameType1 nameField;

    private DimensionType rangeDimensionField;

    private TestMethodType testMethodField;

    private PeriodType usabilityPeriodField;

    private ValueType valueField;

    private ValueQualifierType[] valueQualifierField;

    private ValueQuantityType valueQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameCodeType NameCode
    {
        get => nameCodeField;
        set => nameCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TestMethodType TestMethod
    {
        get => testMethodField;
        set => testMethodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValueType Value
    {
        get => valueField;
        set => valueField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValueQuantityType ValueQuantity
    {
        get => valueQuantityField;
        set => valueQuantityField = value;
    }

    /// <remarks />
    [XmlElement("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValueQualifierType[] ValueQualifier
    {
        get => valueQualifierField;
        set => valueQualifierField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ImportanceCodeType ImportanceCode
    {
        get => importanceCodeField;
        set => importanceCodeField = value;
    }

    /// <remarks />
    [XmlElement("ListValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ListValueType[] ListValue
    {
        get => listValueField;
        set => listValueField = value;
    }

    /// <remarks />
    public PeriodType UsabilityPeriod
    {
        get => usabilityPeriodField;
        set => usabilityPeriodField = value;
    }

    /// <remarks />
    [XmlElement("ItemPropertyGroup")]
    public ItemPropertyGroupType[] ItemPropertyGroup
    {
        get => itemPropertyGroupField;
        set => itemPropertyGroupField = value;
    }

    /// <remarks />
    public DimensionType RangeDimension
    {
        get => rangeDimensionField;
        set => rangeDimensionField = value;
    }

    /// <remarks />
    public ItemPropertyRangeType ItemPropertyRange
    {
        get => itemPropertyRangeField;
        set => itemPropertyRangeField = value;
    }
}