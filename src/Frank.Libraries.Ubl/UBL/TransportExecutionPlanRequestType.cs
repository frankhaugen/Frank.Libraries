namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlanRequest-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportExecutionPlanRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlanRequest-2", IsNullable = false)]
public partial class TransportExecutionPlanRequestType
{

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private CustomizationIDType customizationIDField;

    private ProfileIDType profileIDField;

    private ProfileExecutionIDType profileExecutionIDField;

    private IDType idField;

    private VersionIDType versionIDField;

    private CopyIndicatorType copyIndicatorField;

    private UUIDType uUIDField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private DocumentStatusCodeType documentStatusCodeField;

    private DocumentStatusReasonCodeType documentStatusReasonCodeField;

    private DocumentStatusReasonDescriptionType[] documentStatusReasonDescriptionField;

    private NoteType[] noteField;

    private TransportUserRemarksType[] transportUserRemarksField;

    private PartyType senderPartyField;

    private PartyType receiverPartyField;

    private PartyType transportUserPartyField;

    private PartyType transportServiceProviderPartyField;

    private PartyType payeePartyField;

    private SignatureType[] signatureField;

    private DocumentReferenceType transportExecutionPlanDocumentReferenceField;

    private DocumentReferenceType transportServiceDescriptionDocumentReferenceField;

    private DocumentReferenceType[] additionalDocumentReferenceField;

    private ContractType transportContractField;

    private PeriodType[] transportServiceProviderResponseDeadlinePeriodField;

    private TransportationServiceType mainTransportationServiceField;

    private TransportationServiceType[] additionalTransportationServiceField;

    private PeriodType serviceStartTimePeriodField;

    private PeriodType serviceEndTimePeriodField;

    private LocationType1 fromLocationField;

    private LocationType1 toLocationField;

    private LocationType1 atLocationField;

    private TransportExecutionTermsType transportExecutionTermsField;

    private ConsignmentType[] consignmentField;

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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusCodeType DocumentStatusCode
    {
        get
        {
            return this.documentStatusCodeField;
        }
        set
        {
            this.documentStatusCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusReasonCodeType DocumentStatusReasonCode
    {
        get
        {
            return this.documentStatusReasonCodeField;
        }
        set
        {
            this.documentStatusReasonCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentStatusReasonDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusReasonDescriptionType[] DocumentStatusReasonDescription
    {
        get
        {
            return this.documentStatusReasonDescriptionField;
        }
        set
        {
            this.documentStatusReasonDescriptionField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("TransportUserRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportUserRemarksType[] TransportUserRemarks
    {
        get
        {
            return this.transportUserRemarksField;
        }
        set
        {
            this.transportUserRemarksField = value;
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType TransportUserParty
    {
        get
        {
            return this.transportUserPartyField;
        }
        set
        {
            this.transportUserPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType TransportServiceProviderParty
    {
        get
        {
            return this.transportServiceProviderPartyField;
        }
        set
        {
            this.transportServiceProviderPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType PayeeParty
    {
        get
        {
            return this.payeePartyField;
        }
        set
        {
            this.payeePartyField = value;
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
    public DocumentReferenceType TransportExecutionPlanDocumentReference
    {
        get
        {
            return this.transportExecutionPlanDocumentReferenceField;
        }
        set
        {
            this.transportExecutionPlanDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType TransportServiceDescriptionDocumentReference
    {
        get
        {
            return this.transportServiceDescriptionDocumentReferenceField;
        }
        set
        {
            this.transportServiceDescriptionDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] AdditionalDocumentReference
    {
        get
        {
            return this.additionalDocumentReferenceField;
        }
        set
        {
            this.additionalDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ContractType TransportContract
    {
        get
        {
            return this.transportContractField;
        }
        set
        {
            this.transportContractField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderResponseDeadlinePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] TransportServiceProviderResponseDeadlinePeriod
    {
        get
        {
            return this.transportServiceProviderResponseDeadlinePeriodField;
        }
        set
        {
            this.transportServiceProviderResponseDeadlinePeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportationServiceType MainTransportationService
    {
        get
        {
            return this.mainTransportationServiceField;
        }
        set
        {
            this.mainTransportationServiceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportationServiceType[] AdditionalTransportationService
    {
        get
        {
            return this.additionalTransportationServiceField;
        }
        set
        {
            this.additionalTransportationServiceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType ServiceStartTimePeriod
    {
        get
        {
            return this.serviceStartTimePeriodField;
        }
        set
        {
            this.serviceStartTimePeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType ServiceEndTimePeriod
    {
        get
        {
            return this.serviceEndTimePeriodField;
        }
        set
        {
            this.serviceEndTimePeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LocationType1 FromLocation
    {
        get
        {
            return this.fromLocationField;
        }
        set
        {
            this.fromLocationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LocationType1 ToLocation
    {
        get
        {
            return this.toLocationField;
        }
        set
        {
            this.toLocationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LocationType1 AtLocation
    {
        get
        {
            return this.atLocationField;
        }
        set
        {
            this.atLocationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportExecutionTermsType TransportExecutionTerms
    {
        get
        {
            return this.transportExecutionTermsField;
        }
        set
        {
            this.transportExecutionTermsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ConsignmentType[] Consignment
    {
        get
        {
            return this.consignmentField;
        }
        set
        {
            this.consignmentField = value;
        }
    }
}