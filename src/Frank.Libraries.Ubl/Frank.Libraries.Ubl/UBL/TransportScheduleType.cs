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
[XmlRoot("TransportSchedule", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportScheduleType
{
    private TransportEventType actualArrivalTransportEventField;

    private TransportEventType actualDepartureTransportEventField;

    private TransportEventType estimatedArrivalTransportEventField;

    private TransportEventType estimatedDepartureTransportEventField;

    private TransportEventType plannedArrivalTransportEventField;

    private TransportEventType plannedDepartureTransportEventField;

    private ReferenceDateType referenceDateField;

    private ReferenceTimeType referenceTimeField;

    private ReliabilityPercentType reliabilityPercentField;

    private RemarksType[] remarksField;

    private SequenceNumericType sequenceNumericField;

    private LocationType1 statusLocationField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumericType SequenceNumeric
    {
        get => sequenceNumericField;
        set => sequenceNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceDateType ReferenceDate
    {
        get => referenceDateField;
        set => referenceDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceTimeType ReferenceTime
    {
        get => referenceTimeField;
        set => referenceTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReliabilityPercentType ReliabilityPercent
    {
        get => reliabilityPercentField;
        set => reliabilityPercentField = value;
    }

    /// <remarks />
    [XmlElement("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks
    {
        get => remarksField;
        set => remarksField = value;
    }

    /// <remarks />
    public LocationType1 StatusLocation
    {
        get => statusLocationField;
        set => statusLocationField = value;
    }

    /// <remarks />
    public TransportEventType ActualArrivalTransportEvent
    {
        get => actualArrivalTransportEventField;
        set => actualArrivalTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType ActualDepartureTransportEvent
    {
        get => actualDepartureTransportEventField;
        set => actualDepartureTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType EstimatedDepartureTransportEvent
    {
        get => estimatedDepartureTransportEventField;
        set => estimatedDepartureTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType EstimatedArrivalTransportEvent
    {
        get => estimatedArrivalTransportEventField;
        set => estimatedArrivalTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType PlannedDepartureTransportEvent
    {
        get => plannedDepartureTransportEventField;
        set => plannedDepartureTransportEventField = value;
    }

    /// <remarks />
    public TransportEventType PlannedArrivalTransportEvent
    {
        get => plannedArrivalTransportEventField;
        set => plannedArrivalTransportEventField = value;
    }
}