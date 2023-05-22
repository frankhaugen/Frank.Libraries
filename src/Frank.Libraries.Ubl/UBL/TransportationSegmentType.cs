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
[XmlRoot("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportationSegmentType
{
    private ConsignmentType referencedConsignmentField;

    private SequenceNumericType sequenceNumericField;

    private ShipmentStageType[] shipmentStageField;

    private TransportationServiceType transportationServiceField;

    private TransportExecutionPlanReferenceIDType transportExecutionPlanReferenceIDField;

    private PartyType transportServiceProviderPartyField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumericType SequenceNumeric
    {
        get => sequenceNumericField;
        set => sequenceNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID
    {
        get => transportExecutionPlanReferenceIDField;
        set => transportExecutionPlanReferenceIDField = value;
    }

    /// <remarks />
    public TransportationServiceType TransportationService
    {
        get => transportationServiceField;
        set => transportationServiceField = value;
    }

    /// <remarks />
    public PartyType TransportServiceProviderParty
    {
        get => transportServiceProviderPartyField;
        set => transportServiceProviderPartyField = value;
    }

    /// <remarks />
    public ConsignmentType ReferencedConsignment
    {
        get => referencedConsignmentField;
        set => referencedConsignmentField = value;
    }

    /// <remarks />
    [XmlElement("ShipmentStage")]
    public ShipmentStageType[] ShipmentStage
    {
        get => shipmentStageField;
        set => shipmentStageField = value;
    }
}