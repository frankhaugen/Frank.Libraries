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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlan-2")]
[XmlRoot("TransportExecutionPlan", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlan-2", IsNullable = false)]
public class TransportExecutionPlanType
{
    private DocumentReferenceType[] additionalDocumentReferenceField;

    private TransportationServiceType[] additionalTransportationServiceField;

    private LocationType1 atLocationField;

    private PartyType billToPartyField;

    private ConsignmentType[] consignmentField;

    private CopyIndicatorType copyIndicatorField;

    private CustomizationIDType customizationIDField;

    private DocumentStatusCodeType documentStatusCodeField;

    private DocumentStatusReasonCodeType documentStatusReasonCodeField;

    private DocumentStatusReasonDescriptionType[] documentStatusReasonDescriptionField;

    private LocationType1 fromLocationField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private TransportationServiceType mainTransportationServiceField;

    private NoteType[] noteField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private PartyType receiverPartyField;

    private PartyType senderPartyField;

    private PeriodType serviceEndTimePeriodField;

    private PeriodType serviceStartTimePeriodField;

    private SignatureType[] signatureField;

    private LocationType1 toLocationField;

    private ContractType transportContractField;

    private DocumentReferenceType transportExecutionPlanDocumentReferenceField;

    private DocumentReferenceType transportExecutionPlanRequestDocumentReferenceField;

    private TransportExecutionTermsType transportExecutionTermsField;

    private DocumentReferenceType transportServiceDescriptionDocumentReferenceField;

    private PartyType transportServiceProviderPartyField;

    private TransportServiceProviderRemarksType[] transportServiceProviderRemarksField;

    private PeriodType transportServiceProviderResponseRequiredPeriodField;

    private PartyType transportUserPartyField;

    private TransportUserRemarksType[] transportUserRemarksField;

    private PeriodType[] transportUserResponseRequiredPeriodField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private UUIDType uUIDField;

    private PeriodType[] validityPeriodField;

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
    public VersionIDType VersionID
    {
        get => versionIDField;
        set => versionIDField = value;
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
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusCodeType DocumentStatusCode
    {
        get => documentStatusCodeField;
        set => documentStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusReasonCodeType DocumentStatusReasonCode
    {
        get => documentStatusReasonCodeField;
        set => documentStatusReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement("DocumentStatusReasonDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusReasonDescriptionType[] DocumentStatusReasonDescription
    {
        get => documentStatusReasonDescriptionField;
        set => documentStatusReasonDescriptionField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement("TransportUserRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportUserRemarksType[] TransportUserRemarks
    {
        get => transportUserRemarksField;
        set => transportUserRemarksField = value;
    }

    /// <remarks />
    [XmlElement("TransportServiceProviderRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportServiceProviderRemarksType[] TransportServiceProviderRemarks
    {
        get => transportServiceProviderRemarksField;
        set => transportServiceProviderRemarksField = value;
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
    public PartyType TransportUserParty
    {
        get => transportUserPartyField;
        set => transportUserPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType TransportServiceProviderParty
    {
        get => transportServiceProviderPartyField;
        set => transportServiceProviderPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType BillToParty
    {
        get => billToPartyField;
        set => billToPartyField = value;
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
    public DocumentReferenceType TransportExecutionPlanRequestDocumentReference
    {
        get => transportExecutionPlanRequestDocumentReferenceField;
        set => transportExecutionPlanRequestDocumentReferenceField = value;
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
    public DocumentReferenceType TransportServiceDescriptionDocumentReference
    {
        get => transportServiceDescriptionDocumentReferenceField;
        set => transportServiceDescriptionDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] AdditionalDocumentReference
    {
        get => additionalDocumentReferenceField;
        set => additionalDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ContractType TransportContract
    {
        get => transportContractField;
        set => transportContractField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType TransportServiceProviderResponseRequiredPeriod
    {
        get => transportServiceProviderResponseRequiredPeriodField;
        set => transportServiceProviderResponseRequiredPeriodField = value;
    }

    /// <remarks />
    [XmlElement("TransportUserResponseRequiredPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] TransportUserResponseRequiredPeriod
    {
        get => transportUserResponseRequiredPeriodField;
        set => transportUserResponseRequiredPeriodField = value;
    }

    /// <remarks />
    [XmlElement("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportationServiceType MainTransportationService
    {
        get => mainTransportationServiceField;
        set => mainTransportationServiceField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportationServiceType[] AdditionalTransportationService
    {
        get => additionalTransportationServiceField;
        set => additionalTransportationServiceField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType ServiceStartTimePeriod
    {
        get => serviceStartTimePeriodField;
        set => serviceStartTimePeriodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType ServiceEndTimePeriod
    {
        get => serviceEndTimePeriodField;
        set => serviceEndTimePeriodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LocationType1 FromLocation
    {
        get => fromLocationField;
        set => fromLocationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LocationType1 ToLocation
    {
        get => toLocationField;
        set => toLocationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LocationType1 AtLocation
    {
        get => atLocationField;
        set => atLocationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TransportExecutionTermsType TransportExecutionTerms
    {
        get => transportExecutionTermsField;
        set => transportExecutionTermsField = value;
    }

    /// <remarks />
    [XmlElement("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ConsignmentType[] Consignment
    {
        get => consignmentField;
        set => consignmentField = value;
    }
}