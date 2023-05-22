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
[XmlRoot("PromotionalSpecification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PromotionalSpecificationType
{
    private EventTacticType[] eventTacticField;

    private PromotionalEventLineItemType[] promotionalEventLineItemField;

    private SpecificationIDType specificationIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecificationIDType SpecificationID
    {
        get => specificationIDField;
        set => specificationIDField = value;
    }

    /// <remarks />
    [XmlElement("PromotionalEventLineItem")]
    public PromotionalEventLineItemType[] PromotionalEventLineItem
    {
        get => promotionalEventLineItemField;
        set => promotionalEventLineItemField = value;
    }

    /// <remarks />
    [XmlElement("EventTactic")]
    public EventTacticType[] EventTactic
    {
        get => eventTacticField;
        set => eventTacticField = value;
    }
}