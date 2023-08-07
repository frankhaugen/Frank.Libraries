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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ContractAwardNotice-2")]
[XmlRoot("ContractAwardNotice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ContractAwardNotice-2", IsNullable = false)]
public class ContractAwardNoticeType
{
    private ContractFolderIDType contractFolderIDField;

    private ContractingPartyType contractingPartyField;

    private CopyIndicatorType copyIndicatorField;

    private CustomizationIDType customizationIDField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private DocumentReferenceType[] minutesDocumentReferenceField;

    private NoteType[] noteField;

    private CustomerPartyType originatorCustomerPartyField;

    private DocumentReferenceType[] previousDocumentReferenceField;

    private ProcurementProjectType procurementProjectField;

    private ProcurementProjectLotType[] procurementProjectLotField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private PublishAwardIndicatorType publishAwardIndicatorField;

    private PartyType receiverPartyField;

    private RegulatoryDomainType[] regulatoryDomainField;

    private SignatureType[] signatureField;

    private TenderingProcessType tenderingProcessField;

    private TenderingTermsType tenderingTermsField;

    private TenderResultType[] tenderResultField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

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
    public ContractFolderIDType ContractFolderID
    {
        get => contractFolderIDField;
        set => contractFolderIDField = value;
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
    [XmlElement("RegulatoryDomain", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegulatoryDomainType[] RegulatoryDomain
    {
        get => regulatoryDomainField;
        set => regulatoryDomainField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PublishAwardIndicatorType PublishAwardIndicator
    {
        get => publishAwardIndicatorField;
        set => publishAwardIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("PreviousDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] PreviousDocumentReference
    {
        get => previousDocumentReferenceField;
        set => previousDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("MinutesDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] MinutesDocumentReference
    {
        get => minutesDocumentReferenceField;
        set => minutesDocumentReferenceField = value;
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
    public ContractingPartyType ContractingParty
    {
        get => contractingPartyField;
        set => contractingPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType OriginatorCustomerParty
    {
        get => originatorCustomerPartyField;
        set => originatorCustomerPartyField = value;
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
    public TenderingTermsType TenderingTerms
    {
        get => tenderingTermsField;
        set => tenderingTermsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TenderingProcessType TenderingProcess
    {
        get => tenderingProcessField;
        set => tenderingProcessField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ProcurementProjectType ProcurementProject
    {
        get => procurementProjectField;
        set => procurementProjectField = value;
    }

    /// <remarks />
    [XmlElement("ProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ProcurementProjectLotType[] ProcurementProjectLot
    {
        get => procurementProjectLotField;
        set => procurementProjectLotField = value;
    }

    /// <remarks />
    [XmlElement("TenderResult", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TenderResultType[] TenderResult
    {
        get => tenderResultField;
        set => tenderResultField = value;
    }
}