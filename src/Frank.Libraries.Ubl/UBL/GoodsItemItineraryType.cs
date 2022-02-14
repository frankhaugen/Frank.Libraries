namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2")]
[System.Xml.Serialization.XmlRootAttribute("GoodsItemItinerary", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2", IsNullable = false)]
public partial class GoodsItemItineraryType
{

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private CustomizationIDType customizationIDField;

    private ProfileIDType profileIDField;

    private ProfileExecutionIDType profileExecutionIDField;

    private IDType idField;

    private CopyIndicatorType copyIndicatorField;

    private UUIDType uUIDField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private NoteType[] noteField;

    private VersionIDType versionIDField;

    private TransportExecutionPlanReferenceIDType transportExecutionPlanReferenceIDField;

    private SignatureType[] signatureField;

    private PartyType senderPartyField;

    private PartyType receiverPartyField;

    private ConsignmentType[] referencedConsignmentField;

    private TransportEquipmentType[] referencedTransportEquipmentField;

    private PackageType[] referencedPackageField;

    private GoodsItemType[] referencedGoodsItemField;

    private TransportationSegmentType[] transportationSegmentField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get
        {
            return this.uBLExtensionsField;
        }
        set
        {
            this.uBLExtensionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get
        {
            return this.uBLVersionIDField;
        }
        set
        {
            this.uBLVersionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get
        {
            return this.customizationIDField;
        }
        set
        {
            this.customizationIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get
        {
            return this.profileIDField;
        }
        set
        {
            this.profileIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get
        {
            return this.profileExecutionIDField;
        }
        set
        {
            this.profileExecutionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CopyIndicatorType CopyIndicator
    {
        get
        {
            return this.copyIndicatorField;
        }
        set
        {
            this.copyIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get
        {
            return this.uUIDField;
        }
        set
        {
            this.uUIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get
        {
            return this.issueDateField;
        }
        set
        {
            this.issueDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get
        {
            return this.issueTimeField;
        }
        set
        {
            this.issueTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VersionIDType VersionID
    {
        get
        {
            return this.versionIDField;
        }
        set
        {
            this.versionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID
    {
        get
        {
            return this.transportExecutionPlanReferenceIDField;
        }
        set
        {
            this.transportExecutionPlanReferenceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType SenderParty
    {
        get
        {
            return this.senderPartyField;
        }
        set
        {
            this.senderPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType ReceiverParty
    {
        get
        {
            return this.receiverPartyField;
        }
        set
        {
            this.receiverPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferencedConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ConsignmentType[] ReferencedConsignment
    {
        get
        {
            return this.referencedConsignmentField;
        }
        set
        {
            this.referencedConsignmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferencedTransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportEquipmentType[] ReferencedTransportEquipment
    {
        get
        {
            return this.referencedTransportEquipmentField;
        }
        set
        {
            this.referencedTransportEquipmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferencedPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PackageType[] ReferencedPackage
    {
        get
        {
            return this.referencedPackageField;
        }
        set
        {
            this.referencedPackageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferencedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public GoodsItemType[] ReferencedGoodsItem
    {
        get
        {
            return this.referencedGoodsItemField;
        }
        set
        {
            this.referencedGoodsItemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportationSegmentType[] TransportationSegment
    {
        get
        {
            return this.transportationSegmentField;
        }
        set
        {
            this.transportationSegmentField = value;
        }
    }
}