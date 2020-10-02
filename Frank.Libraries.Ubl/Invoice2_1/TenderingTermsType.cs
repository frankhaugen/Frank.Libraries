namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderingTermsType
    {

        private AwardingMethodTypeCodeType _awardingMethodTypeCodeField;

        private PriceEvaluationCodeType _priceEvaluationCodeField;

        private MaximumVariantQuantityType _maximumVariantQuantityField;

        private VariantConstraintIndicatorType _variantConstraintIndicatorField;

        private AcceptedVariantsDescriptionType[] _acceptedVariantsDescriptionField;

        private PriceRevisionFormulaDescriptionType[] _priceRevisionFormulaDescriptionField;

        private FundingProgramCodeType _fundingProgramCodeField;

        private FundingProgramType[] _fundingProgramField;

        private MaximumAdvertisementAmountType _maximumAdvertisementAmountField;

        private NoteType[] _noteField;

        private PaymentFrequencyCodeType _paymentFrequencyCodeField;

        private EconomicOperatorRegistryUriType _economicOperatorRegistryUriField;

        private RequiredCurriculaIndicatorType _requiredCurriculaIndicatorField;

        private OtherConditionsIndicatorType _otherConditionsIndicatorField;

        private AdditionalConditionsType[] _additionalConditionsField;

        private LatestSecurityClearanceDateType _latestSecurityClearanceDateField;

        private DocumentationFeeAmountType _documentationFeeAmountField;

        private ClauseType[] _penaltyClauseField;

        private FinancialGuaranteeType[] _requiredFinancialGuaranteeField;

        private DocumentReferenceType _procurementLegislationDocumentReferenceField;

        private DocumentReferenceType _fiscalLegislationDocumentReferenceField;

        private DocumentReferenceType _environmentalLegislationDocumentReferenceField;

        private DocumentReferenceType _employmentLegislationDocumentReferenceField;

        private DocumentReferenceType[] _contractualDocumentReferenceField;

        private DocumentReferenceType _callForTendersDocumentReferenceField;

        private PeriodType _warrantyValidityPeriodField;

        private PaymentTermsType[] _paymentTermsField;

        private TendererQualificationRequestType[] _tendererQualificationRequestField;

        private SubcontractTermsType[] _allowedSubcontractTermsField;

        private TenderPreparationType[] _tenderPreparationField;

        private ContractExecutionRequirementType[] _contractExecutionRequirementField;

        private AwardingTermsType _awardingTermsField;

        private PartyType _additionalInformationPartyField;

        private PartyType _documentProviderPartyField;

        private PartyType _tenderRecipientPartyField;

        private PartyType _contractResponsiblePartyField;

        private PartyType[] _tenderEvaluationPartyField;

        private PeriodType _tenderValidityPeriodField;

        private PeriodType _contractAcceptancePeriodField;

        private AppealTermsType _appealTermsField;

        private LanguageType[] _languageField;

        private BudgetAccountLineType[] _budgetAccountLineField;

        private DocumentReferenceType _replacedNoticeDocumentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AwardingMethodTypeCodeType AwardingMethodTypeCode
        {
            get
            {
                return _awardingMethodTypeCodeField;
            }
            set
            {
                _awardingMethodTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceEvaluationCodeType PriceEvaluationCode
        {
            get
            {
                return _priceEvaluationCodeField;
            }
            set
            {
                _priceEvaluationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumVariantQuantityType MaximumVariantQuantity
        {
            get
            {
                return _maximumVariantQuantityField;
            }
            set
            {
                _maximumVariantQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VariantConstraintIndicatorType VariantConstraintIndicator
        {
            get
            {
                return _variantConstraintIndicatorField;
            }
            set
            {
                _variantConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AcceptedVariantsDescriptionType[] AcceptedVariantsDescription
        {
            get
            {
                return _acceptedVariantsDescriptionField;
            }
            set
            {
                _acceptedVariantsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceRevisionFormulaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceRevisionFormulaDescriptionType[] PriceRevisionFormulaDescription
        {
            get
            {
                return _priceRevisionFormulaDescriptionField;
            }
            set
            {
                _priceRevisionFormulaDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FundingProgramCodeType FundingProgramCode
        {
            get
            {
                return _fundingProgramCodeField;
            }
            set
            {
                _fundingProgramCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FundingProgram", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FundingProgramType[] FundingProgram
        {
            get
            {
                return _fundingProgramField;
            }
            set
            {
                _fundingProgramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAdvertisementAmountType MaximumAdvertisementAmount
        {
            get
            {
                return _maximumAdvertisementAmountField;
            }
            set
            {
                _maximumAdvertisementAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentFrequencyCodeType PaymentFrequencyCode
        {
            get
            {
                return _paymentFrequencyCodeField;
            }
            set
            {
                _paymentFrequencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EconomicOperatorRegistryUriType EconomicOperatorRegistryUri
        {
            get
            {
                return _economicOperatorRegistryUriField;
            }
            set
            {
                _economicOperatorRegistryUriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredCurriculaIndicatorType RequiredCurriculaIndicator
        {
            get
            {
                return _requiredCurriculaIndicatorField;
            }
            set
            {
                _requiredCurriculaIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OtherConditionsIndicatorType OtherConditionsIndicator
        {
            get
            {
                return _otherConditionsIndicatorField;
            }
            set
            {
                _otherConditionsIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalConditionsType[] AdditionalConditions
        {
            get
            {
                return _additionalConditionsField;
            }
            set
            {
                _additionalConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestSecurityClearanceDateType LatestSecurityClearanceDate
        {
            get
            {
                return _latestSecurityClearanceDateField;
            }
            set
            {
                _latestSecurityClearanceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentationFeeAmountType DocumentationFeeAmount
        {
            get
            {
                return _documentationFeeAmountField;
            }
            set
            {
                _documentationFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PenaltyClause")]
        public ClauseType[] PenaltyClause
        {
            get
            {
                return _penaltyClauseField;
            }
            set
            {
                _penaltyClauseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredFinancialGuarantee")]
        public FinancialGuaranteeType[] RequiredFinancialGuarantee
        {
            get
            {
                return _requiredFinancialGuaranteeField;
            }
            set
            {
                _requiredFinancialGuaranteeField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ProcurementLegislationDocumentReference
        {
            get
            {
                return _procurementLegislationDocumentReferenceField;
            }
            set
            {
                _procurementLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType FiscalLegislationDocumentReference
        {
            get
            {
                return _fiscalLegislationDocumentReferenceField;
            }
            set
            {
                _fiscalLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType EnvironmentalLegislationDocumentReference
        {
            get
            {
                return _environmentalLegislationDocumentReferenceField;
            }
            set
            {
                _environmentalLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType EmploymentLegislationDocumentReference
        {
            get
            {
                return _employmentLegislationDocumentReferenceField;
            }
            set
            {
                _employmentLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractualDocumentReference")]
        public DocumentReferenceType[] ContractualDocumentReference
        {
            get
            {
                return _contractualDocumentReferenceField;
            }
            set
            {
                _contractualDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CallForTendersDocumentReference
        {
            get
            {
                return _callForTendersDocumentReferenceField;
            }
            set
            {
                _callForTendersDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return _warrantyValidityPeriodField;
            }
            set
            {
                _warrantyValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return _paymentTermsField;
            }
            set
            {
                _paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TendererQualificationRequest")]
        public TendererQualificationRequestType[] TendererQualificationRequest
        {
            get
            {
                return _tendererQualificationRequestField;
            }
            set
            {
                _tendererQualificationRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedSubcontractTerms")]
        public SubcontractTermsType[] AllowedSubcontractTerms
        {
            get
            {
                return _allowedSubcontractTermsField;
            }
            set
            {
                _allowedSubcontractTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderPreparation")]
        public TenderPreparationType[] TenderPreparation
        {
            get
            {
                return _tenderPreparationField;
            }
            set
            {
                _tenderPreparationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractExecutionRequirement")]
        public ContractExecutionRequirementType[] ContractExecutionRequirement
        {
            get
            {
                return _contractExecutionRequirementField;
            }
            set
            {
                _contractExecutionRequirementField = value;
            }
        }

        /// <remarks/>
        public AwardingTermsType AwardingTerms
        {
            get
            {
                return _awardingTermsField;
            }
            set
            {
                _awardingTermsField = value;
            }
        }

        /// <remarks/>
        public PartyType AdditionalInformationParty
        {
            get
            {
                return _additionalInformationPartyField;
            }
            set
            {
                _additionalInformationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType DocumentProviderParty
        {
            get
            {
                return _documentProviderPartyField;
            }
            set
            {
                _documentProviderPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType TenderRecipientParty
        {
            get
            {
                return _tenderRecipientPartyField;
            }
            set
            {
                _tenderRecipientPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ContractResponsibleParty
        {
            get
            {
                return _contractResponsiblePartyField;
            }
            set
            {
                _contractResponsiblePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderEvaluationParty")]
        public PartyType[] TenderEvaluationParty
        {
            get
            {
                return _tenderEvaluationPartyField;
            }
            set
            {
                _tenderEvaluationPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType TenderValidityPeriod
        {
            get
            {
                return _tenderValidityPeriodField;
            }
            set
            {
                _tenderValidityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType ContractAcceptancePeriod
        {
            get
            {
                return _contractAcceptancePeriodField;
            }
            set
            {
                _contractAcceptancePeriodField = value;
            }
        }

        /// <remarks/>
        public AppealTermsType AppealTerms
        {
            get
            {
                return _appealTermsField;
            }
            set
            {
                _appealTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Language")]
        public LanguageType[] Language
        {
            get
            {
                return _languageField;
            }
            set
            {
                _languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BudgetAccountLine")]
        public BudgetAccountLineType[] BudgetAccountLine
        {
            get
            {
                return _budgetAccountLineField;
            }
            set
            {
                _budgetAccountLineField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ReplacedNoticeDocumentReference
        {
            get
            {
                return _replacedNoticeDocumentReferenceField;
            }
            set
            {
                _replacedNoticeDocumentReferenceField = value;
            }
        }
    }
}