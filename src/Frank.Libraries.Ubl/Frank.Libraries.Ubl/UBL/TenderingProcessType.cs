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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TenderingProcessType
{
    private DocumentReferenceType[] additionalDocumentReferenceField;

    private AuctionTermsType auctionTermsField;

    private CandidateReductionConstraintIndicatorType candidateReductionConstraintIndicatorField;

    private ContractingSystemCodeType contractingSystemCodeField;

    private DescriptionType[] descriptionField;

    private PeriodType documentAvailabilityPeriodField;

    private EconomicOperatorShortListType economicOperatorShortListField;

    private ExpenseCodeType expenseCodeField;

    private FrameworkAgreementType frameworkAgreementField;

    private GovernmentAgreementConstraintIndicatorType governmentAgreementConstraintIndicatorField;

    private IDType idField;

    private PeriodType invitationSubmissionPeriodField;

    private NegotiationDescriptionType[] negotiationDescriptionField;

    private DocumentReferenceType[] noticeDocumentReferenceField;

    private EventType[] openTenderEventField;

    private OriginalContractingSystemIDType originalContractingSystemIDField;

    private PeriodType participationRequestReceptionPeriodField;

    private PartPresentationCodeType partPresentationCodeField;

    private ProcedureCodeType procedureCodeField;

    private ProcessJustificationType[] processJustificationField;

    private SubmissionMethodCodeType submissionMethodCodeField;

    private PeriodType tenderSubmissionDeadlinePeriodField;

    private UrgencyCodeType urgencyCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OriginalContractingSystemIDType OriginalContractingSystemID
    {
        get => originalContractingSystemIDField;
        set => originalContractingSystemIDField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("NegotiationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NegotiationDescriptionType[] NegotiationDescription
    {
        get => negotiationDescriptionField;
        set => negotiationDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcedureCodeType ProcedureCode
    {
        get => procedureCodeField;
        set => procedureCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UrgencyCodeType UrgencyCode
    {
        get => urgencyCodeField;
        set => urgencyCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpenseCodeType ExpenseCode
    {
        get => expenseCodeField;
        set => expenseCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PartPresentationCodeType PartPresentationCode
    {
        get => partPresentationCodeField;
        set => partPresentationCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractingSystemCodeType ContractingSystemCode
    {
        get => contractingSystemCodeField;
        set => contractingSystemCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubmissionMethodCodeType SubmissionMethodCode
    {
        get => submissionMethodCodeField;
        set => submissionMethodCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CandidateReductionConstraintIndicatorType CandidateReductionConstraintIndicator
    {
        get => candidateReductionConstraintIndicatorField;
        set => candidateReductionConstraintIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GovernmentAgreementConstraintIndicatorType GovernmentAgreementConstraintIndicator
    {
        get => governmentAgreementConstraintIndicatorField;
        set => governmentAgreementConstraintIndicatorField = value;
    }

    /// <remarks />
    public PeriodType DocumentAvailabilityPeriod
    {
        get => documentAvailabilityPeriodField;
        set => documentAvailabilityPeriodField = value;
    }

    /// <remarks />
    public PeriodType TenderSubmissionDeadlinePeriod
    {
        get => tenderSubmissionDeadlinePeriodField;
        set => tenderSubmissionDeadlinePeriodField = value;
    }

    /// <remarks />
    public PeriodType InvitationSubmissionPeriod
    {
        get => invitationSubmissionPeriodField;
        set => invitationSubmissionPeriodField = value;
    }

    /// <remarks />
    public PeriodType ParticipationRequestReceptionPeriod
    {
        get => participationRequestReceptionPeriodField;
        set => participationRequestReceptionPeriodField = value;
    }

    /// <remarks />
    [XmlElement("NoticeDocumentReference")]
    public DocumentReferenceType[] NoticeDocumentReference
    {
        get => noticeDocumentReferenceField;
        set => noticeDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalDocumentReference")]
    public DocumentReferenceType[] AdditionalDocumentReference
    {
        get => additionalDocumentReferenceField;
        set => additionalDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ProcessJustification")]
    public ProcessJustificationType[] ProcessJustification
    {
        get => processJustificationField;
        set => processJustificationField = value;
    }

    /// <remarks />
    public EconomicOperatorShortListType EconomicOperatorShortList
    {
        get => economicOperatorShortListField;
        set => economicOperatorShortListField = value;
    }

    /// <remarks />
    [XmlElement("OpenTenderEvent")]
    public EventType[] OpenTenderEvent
    {
        get => openTenderEventField;
        set => openTenderEventField = value;
    }

    /// <remarks />
    public AuctionTermsType AuctionTerms
    {
        get => auctionTermsField;
        set => auctionTermsField = value;
    }

    /// <remarks />
    public FrameworkAgreementType FrameworkAgreement
    {
        get => frameworkAgreementField;
        set => frameworkAgreementField = value;
    }
}