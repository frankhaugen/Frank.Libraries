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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatus-2")]
[XmlRoot("TransportationStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatus-2", IsNullable = false)]
public class TransportationStatusType
{
    private CarrierAssignedIDType carrierAssignedIDField;

    private ConsignmentType[] consignmentField;

    private CustomizationIDType customizationIDField;

    private DescriptionType[] descriptionField;

    private DocumentReferenceType[] documentReferenceField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private NameType1 nameField;

    private NoteType[] noteField;

    private OtherInstructionType otherInstructionField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private PartyType receiverPartyField;

    private PartyType senderPartyField;

    private ShippingOrderIDType shippingOrderIDField;

    private SignatureType[] signatureField;

    private LocationType1[] statusLocationField;

    private PeriodType[] statusPeriodField;

    private DocumentReferenceType transportationStatusRequestDocumentReferenceField;

    private TransportationStatusTypeCodeType transportationStatusTypeCodeField;

    private TransportEventType[] transportEventField;

    private DocumentReferenceType transportExecutionPlanDocumentReferenceField;

    private TransportExecutionStatusCodeType transportExecutionStatusCodeField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private TransportEventType updatedDeliveryTransportEventField;

    private TransportEventType updatedPickupTransportEventField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlArrayItem("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get => uBLExtensionsField;
        set => uBLExtensionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get => uBLVersionIDField;
        set => uBLVersionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get => customizationIDField;
        set => customizationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get => profileIDField;
        set => profileIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get => profileExecutionIDField;
        set => profileExecutionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierAssignedIDType CarrierAssignedID
    {
        get => carrierAssignedIDField;
        set => carrierAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get => issueDateField;
        set => issueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get => issueTimeField;
        set => issueTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingOrderIDType ShippingOrderID
    {
        get => shippingOrderIDField;
        set => shippingOrderIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OtherInstructionType OtherInstruction
    {
        get => otherInstructionField;
        set => otherInstructionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportationStatusTypeCodeType TransportationStatusTypeCode
    {
        get => transportationStatusTypeCodeField;
        set => transportationStatusTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportExecutionStatusCodeType TransportExecutionStatusCode
    {
        get => transportExecutionStatusCodeField;
        set => transportExecutionStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ConsignmentType[] Consignment
    {
        get => consignmentField;
        set => consignmentField = value;
    }

    /// <remarks />
    [XmlElement("TransportEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportEventType[] TransportEvent
    {
        get => transportEventField;
        set => transportEventField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType SenderParty
    {
        get => senderPartyField;
        set => senderPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType ReceiverParty
    {
        get => receiverPartyField;
        set => receiverPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType TransportationStatusRequestDocumentReference
    {
        get => transportationStatusRequestDocumentReferenceField;
        set => transportationStatusRequestDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType TransportExecutionPlanDocumentReference
    {
        get => transportExecutionPlanDocumentReferenceField;
        set => transportExecutionPlanDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportEventType UpdatedPickupTransportEvent
    {
        get => updatedPickupTransportEventField;
        set => updatedPickupTransportEventField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportEventType UpdatedDeliveryTransportEvent
    {
        get => updatedDeliveryTransportEventField;
        set => updatedDeliveryTransportEventField = value;
    }

    /// <remarks />
    [XmlElement("StatusLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LocationType1[] StatusLocation
    {
        get => statusLocationField;
        set => statusLocationField = value;
    }

    /// <remarks />
    [XmlElement("StatusPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] StatusPeriod
    {
        get => statusPeriodField;
        set => statusPeriodField = value;
    }
}