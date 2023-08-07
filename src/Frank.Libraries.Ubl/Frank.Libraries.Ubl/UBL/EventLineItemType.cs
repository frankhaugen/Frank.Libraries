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
[XmlRoot("EventLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EventLineItemType
{
    private LineNumberNumericType lineNumberNumericField;

    private LocationType1 participatingLocationsLocationField;

    private RetailPlannedImpactType[] retailPlannedImpactField;

    private ItemType supplyItemField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineNumberNumericType LineNumberNumeric
    {
        get => lineNumberNumericField;
        set => lineNumberNumericField = value;
    }

    /// <remarks />
    public LocationType1 ParticipatingLocationsLocation
    {
        get => participatingLocationsLocationField;
        set => participatingLocationsLocationField = value;
    }

    /// <remarks />
    [XmlElement("RetailPlannedImpact")]
    public RetailPlannedImpactType[] RetailPlannedImpact
    {
        get => retailPlannedImpactField;
        set => retailPlannedImpactField = value;
    }

    /// <remarks />
    public ItemType SupplyItem
    {
        get => supplyItemField;
        set => supplyItemField = value;
    }
}