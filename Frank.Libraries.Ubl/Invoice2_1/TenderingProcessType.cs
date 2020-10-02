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

        private IDType idField;

        private OriginalContractingSystemIDType originalContractingSystemIDField;

        private DescriptionType[] descriptionField;

        private NegotiationDescriptionType[] negotiationDescriptionField;

        private ProcedureCodeType procedureCodeField;

        private UrgencyCodeType urgencyCodeField;

        private ExpenseCodeType expenseCodeField;

        private PartPresentationCodeType partPresentationCodeField;

        private ContractingSystemCodeType contractingSystemCodeField;

        private SubmissionMethodCodeType submissionMethodCodeField;

        private CandidateReductionConstraintIndicatorType candidateReductionConstraintIndicatorField;

        private GovernmentAgreementConstraintIndicatorType governmentAgreementConstraintIndicatorField;

        private PeriodType documentAvailabilityPeriodField;

        private PeriodType tenderSubmissionDeadlinePeriodField;

        private PeriodType invitationSubmissionPeriodField;

        private PeriodType participationRequestReceptionPeriodField;

        private DocumentReferenceType[] noticeDocumentReferenceField;

        private DocumentReferenceType[] additionalDocumentReferenceField;

        private ProcessJustificationType[] processJustificationField;

        private EconomicOperatorShortListType economicOperatorShortListField;

        private EventType[] openTenderEventField;

        private AuctionTermsType auctionTermsField;

        private FrameworkAgreementType frameworkAgreementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OriginalContractingSystemIDType OriginalContractingSystemID
        {
            get
            {
                return originalContractingSystemIDField;
            }
            set
            {
                originalContractingSystemIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NegotiationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NegotiationDescriptionType[] NegotiationDescription
        {
            get
            {
                return negotiationDescriptionField;
            }
            set
            {
                negotiationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcedureCodeType ProcedureCode
        {
            get
            {
                return procedureCodeField;
            }
            set
            {
                procedureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UrgencyCodeType UrgencyCode
        {
            get
            {
                return urgencyCodeField;
            }
            set
            {
                urgencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpenseCodeType ExpenseCode
        {
            get
            {
                return expenseCodeField;
            }
            set
            {
                expenseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartPresentationCodeType PartPresentationCode
        {
            get
            {
                return partPresentationCodeField;
            }
            set
            {
                partPresentationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractingSystemCodeType ContractingSystemCode
        {
            get
            {
                return contractingSystemCodeField;
            }
            set
            {
                contractingSystemCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubmissionMethodCodeType SubmissionMethodCode
        {
            get
            {
                return submissionMethodCodeField;
            }
            set
            {
                submissionMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CandidateReductionConstraintIndicatorType CandidateReductionConstraintIndicator
        {
            get
            {
                return candidateReductionConstraintIndicatorField;
            }
            set
            {
                candidateReductionConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GovernmentAgreementConstraintIndicatorType GovernmentAgreementConstraintIndicator
        {
            get
            {
                return governmentAgreementConstraintIndicatorField;
            }
            set
            {
                governmentAgreementConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        public PeriodType DocumentAvailabilityPeriod
        {
            get
            {
                return documentAvailabilityPeriodField;
            }
            set
            {
                documentAvailabilityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType TenderSubmissionDeadlinePeriod
        {
            get
            {
                return tenderSubmissionDeadlinePeriodField;
            }
            set
            {
                tenderSubmissionDeadlinePeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType InvitationSubmissionPeriod
        {
            get
            {
                return invitationSubmissionPeriodField;
            }
            set
            {
                invitationSubmissionPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType ParticipationRequestReceptionPeriod
        {
            get
            {
                return participationRequestReceptionPeriodField;
            }
            set
            {
                participationRequestReceptionPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NoticeDocumentReference")]
        public DocumentReferenceType[] NoticeDocumentReference
        {
            get
            {
                return noticeDocumentReferenceField;
            }
            set
            {
                noticeDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return additionalDocumentReferenceField;
            }
            set
            {
                additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessJustification")]
        public ProcessJustificationType[] ProcessJustification
        {
            get
            {
                return processJustificationField;
            }
            set
            {
                processJustificationField = value;
            }
        }

        /// <remarks/>
        public EconomicOperatorShortListType EconomicOperatorShortList
        {
            get
            {
                return economicOperatorShortListField;
            }
            set
            {
                economicOperatorShortListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OpenTenderEvent")]
        public EventType[] OpenTenderEvent
        {
            get
            {
                return openTenderEventField;
            }
            set
            {
                openTenderEventField = value;
            }
        }

        /// <remarks/>
        public AuctionTermsType AuctionTerms
        {
            get
            {
                return auctionTermsField;
            }
            set
            {
                auctionTermsField = value;
            }
        }

        /// <remarks/>
        public FrameworkAgreementType FrameworkAgreement
        {
            get
            {
                return frameworkAgreementField;
            }
            set
            {
                frameworkAgreementField = value;
            }
        }
    }
}