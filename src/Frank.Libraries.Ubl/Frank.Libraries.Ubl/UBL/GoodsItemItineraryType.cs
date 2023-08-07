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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2")]
[XmlRoot("GoodsItemItinerary", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2", IsNullable = false)]
public class GoodsItemItineraryType
{
    private CopyIndicatorType copyIndicatorField;

    private CustomizationIDType customizationIDField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private NoteType[] noteField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private PartyType receiverPartyField;

    private ConsignmentType[] referencedConsignmentField;

    private GoodsItemType[] referencedGoodsItemField;

    private PackageType[] referencedPackageField;

    private TransportEquipmentType[] referencedTransportEquipmentField;

    private PartyType senderPartyField;

    private SignatureType[] signatureField;

    private TransportationSegmentType[] transportationSegmentField;

    private TransportExecutionPlanReferenceIDType transportExecutionPlanReferenceIDField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private UUIDType uUIDField;

    private VersionIDType versionIDField;

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
    public CopyIndicatorType CopyIndicator
    {
        get => copyIndicatorField;
        set => copyIndicatorField = value;
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
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VersionIDType VersionID
    {
        get => versionIDField;
        set => versionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID
    {
        get => transportExecutionPlanReferenceIDField;
        set => transportExecutionPlanReferenceIDField = value;
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
    [XmlElement("ReferencedConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ConsignmentType[] ReferencedConsignment
    {
        get => referencedConsignmentField;
        set => referencedConsignmentField = value;
    }

    /// <remarks />
    [XmlElement("ReferencedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportEquipmentType[] ReferencedTransportEquipment
    {
        get => referencedTransportEquipmentField;
        set => referencedTransportEquipmentField = value;
    }

    /// <remarks />
    [XmlElement("ReferencedPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PackageType[] ReferencedPackage
    {
        get => referencedPackageField;
        set => referencedPackageField = value;
    }

    /// <remarks />
    [XmlElement("ReferencedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public GoodsItemType[] ReferencedGoodsItem
    {
        get => referencedGoodsItemField;
        set => referencedGoodsItemField = value;
    }

    /// <remarks />
    [XmlElement("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportationSegmentType[] TransportationSegment
    {
        get => transportationSegmentField;
        set => transportationSegmentField = value;
    }
}