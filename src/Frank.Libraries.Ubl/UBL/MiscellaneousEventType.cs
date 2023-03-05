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
[XmlRoot("MiscellaneousEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class MiscellaneousEventType
{
    private EventLineItemType[] eventLineItemField;

    private MiscellaneousEventTypeCodeType miscellaneousEventTypeCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MiscellaneousEventTypeCodeType MiscellaneousEventTypeCode
    {
        get => miscellaneousEventTypeCodeField;
        set => miscellaneousEventTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("EventLineItem")]
    public EventLineItemType[] EventLineItem
    {
        get => eventLineItemField;
        set => eventLineItemField = value;
    }
}