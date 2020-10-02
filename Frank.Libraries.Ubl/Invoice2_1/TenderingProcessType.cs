namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderingProcessType
    {

        private IdType _idField;

        private OriginalContractingSystemIdType _originalContractingSystemIdField;

        private DescriptionType[] _descriptionField;

        private NegotiationDescriptionType[] _negotiationDescriptionField;

        private ProcedureCodeType _procedureCodeField;

        private UrgencyCodeType _urgencyCodeField;

        private ExpenseCodeType _expenseCodeField;

        private PartPresentationCodeType _partPresentationCodeField;

        private ContractingSystemCodeType _contractingSystemCodeField;

        private SubmissionMethodCodeType _submissionMethodCodeField;

        private CandidateReductionConstraintIndicatorType _candidateReductionConstraintIndicatorField;

        private GovernmentAgreementConstraintIndicatorType _governmentAgreementConstraintIndicatorField;

        private PeriodType _documentAvailabilityPeriodField;

        private PeriodType _tenderSubmissionDeadlinePeriodField;

        private PeriodType _invitationSubmissionPeriodField;

        private PeriodType _participationRequestReceptionPeriodField;

        private DocumentReferenceType[] _noticeDocumentReferenceField;

        private DocumentReferenceType[] _additionalDocumentReferenceField;

        private ProcessJustificationType[] _processJustificationField;

        private EconomicOperatorShortListType _economicOperatorShortListField;

        private EventType[] _openTenderEventField;

        private AuctionTermsType _auctionTermsField;

        private FrameworkAgreementType _frameworkAgreementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OriginalContractingSystemIdType OriginalContractingSystemId
        {
            get
            {
                return _originalContractingSystemIdField;
            }
            set
            {
                _originalContractingSystemIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NegotiationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NegotiationDescriptionType[] NegotiationDescription
        {
            get
            {
                return _negotiationDescriptionField;
            }
            set
            {
                _negotiationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcedureCodeType ProcedureCode
        {
            get
            {
                return _procedureCodeField;
            }
            set
            {
                _procedureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UrgencyCodeType UrgencyCode
        {
            get
            {
                return _urgencyCodeField;
            }
            set
            {
                _urgencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpenseCodeType ExpenseCode
        {
            get
            {
                return _expenseCodeField;
            }
            set
            {
                _expenseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartPresentationCodeType PartPresentationCode
        {
            get
            {
                return _partPresentationCodeField;
            }
            set
            {
                _partPresentationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractingSystemCodeType ContractingSystemCode
        {
            get
            {
                return _contractingSystemCodeField;
            }
            set
            {
                _contractingSystemCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubmissionMethodCodeType SubmissionMethodCode
        {
            get
            {
                return _submissionMethodCodeField;
            }
            set
            {
                _submissionMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CandidateReductionConstraintIndicatorType CandidateReductionConstraintIndicator
        {
            get
            {
                return _candidateReductionConstraintIndicatorField;
            }
            set
            {
                _candidateReductionConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GovernmentAgreementConstraintIndicatorType GovernmentAgreementConstraintIndicator
        {
            get
            {
                return _governmentAgreementConstraintIndicatorField;
            }
            set
            {
                _governmentAgreementConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        public PeriodType DocumentAvailabilityPeriod
        {
            get
            {
                return _documentAvailabilityPeriodField;
            }
            set
            {
                _documentAvailabilityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType TenderSubmissionDeadlinePeriod
        {
            get
            {
                return _tenderSubmissionDeadlinePeriodField;
            }
            set
            {
                _tenderSubmissionDeadlinePeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType InvitationSubmissionPeriod
        {
            get
            {
                return _invitationSubmissionPeriodField;
            }
            set
            {
                _invitationSubmissionPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType ParticipationRequestReceptionPeriod
        {
            get
            {
                return _participationRequestReceptionPeriodField;
            }
            set
            {
                _participationRequestReceptionPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NoticeDocumentReference")]
        public DocumentReferenceType[] NoticeDocumentReference
        {
            get
            {
                return _noticeDocumentReferenceField;
            }
            set
            {
                _noticeDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return _additionalDocumentReferenceField;
            }
            set
            {
                _additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessJustification")]
        public ProcessJustificationType[] ProcessJustification
        {
            get
            {
                return _processJustificationField;
            }
            set
            {
                _processJustificationField = value;
            }
        }

        /// <remarks/>
        public EconomicOperatorShortListType EconomicOperatorShortList
        {
            get
            {
                return _economicOperatorShortListField;
            }
            set
            {
                _economicOperatorShortListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OpenTenderEvent")]
        public EventType[] OpenTenderEvent
        {
            get
            {
                return _openTenderEventField;
            }
            set
            {
                _openTenderEventField = value;
            }
        }

        /// <remarks/>
        public AuctionTermsType AuctionTerms
        {
            get
            {
                return _auctionTermsField;
            }
            set
            {
                _auctionTermsField = value;
            }
        }

        /// <remarks/>
        public FrameworkAgreementType FrameworkAgreement
        {
            get
            {
                return _frameworkAgreementField;
            }
            set
            {
                _frameworkAgreementField = value;
            }
        }
    }
}