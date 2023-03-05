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
[XmlRoot("Event", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EventType
{
    private CompletionIndicatorType completionIndicatorField;

    private ContactType[] contactField;

    private StatusType[] currentStatusField;

    private DescriptionType[] descriptionField;

    private IdentificationIDType identificationIDField;

    private LocationType1 occurenceLocationField;

    private OccurrenceDateType occurrenceDateField;

    private OccurrenceTimeType occurrenceTimeField;

    private TypeCodeType typeCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IdentificationIDType IdentificationID
    {
        get => identificationIDField;
        set => identificationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OccurrenceDateType OccurrenceDate
    {
        get => occurrenceDateField;
        set => occurrenceDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OccurrenceTimeType OccurrenceTime
    {
        get => occurrenceTimeField;
        set => occurrenceTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TypeCodeType TypeCode
    {
        get => typeCodeField;
        set => typeCodeField = value;
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
    public CompletionIndicatorType CompletionIndicator
    {
        get => completionIndicatorField;
        set => completionIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("CurrentStatus")]
    public StatusType[] CurrentStatus
    {
        get => currentStatusField;
        set => currentStatusField = value;
    }

    /// <remarks />
    [XmlElement("Contact")]
    public ContactType[] Contact
    {
        get => contactField;
        set => contactField = value;
    }

    /// <remarks />
    public LocationType1 OccurenceLocation
    {
        get => occurenceLocationField;
        set => occurenceLocationField = value;
    }
}