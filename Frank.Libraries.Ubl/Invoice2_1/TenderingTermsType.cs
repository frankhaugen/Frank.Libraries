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

        private AwardingMethodTypeCodeType awardingMethodTypeCodeField;

        private PriceEvaluationCodeType priceEvaluationCodeField;

        private MaximumVariantQuantityType maximumVariantQuantityField;

        private VariantConstraintIndicatorType variantConstraintIndicatorField;

        private AcceptedVariantsDescriptionType[] acceptedVariantsDescriptionField;

        private PriceRevisionFormulaDescriptionType[] priceRevisionFormulaDescriptionField;

        private FundingProgramCodeType fundingProgramCodeField;

        private FundingProgramType[] fundingProgramField;

        private MaximumAdvertisementAmountType maximumAdvertisementAmountField;

        private NoteType[] noteField;

        private PaymentFrequencyCodeType paymentFrequencyCodeField;

        private EconomicOperatorRegistryURIType economicOperatorRegistryURIField;

        private RequiredCurriculaIndicatorType requiredCurriculaIndicatorField;

        private OtherConditionsIndicatorType otherConditionsIndicatorField;

        private AdditionalConditionsType[] additionalConditionsField;

        private LatestSecurityClearanceDateType latestSecurityClearanceDateField;

        private DocumentationFeeAmountType documentationFeeAmountField;

        private ClauseType[] penaltyClauseField;

        private FinancialGuaranteeType[] requiredFinancialGuaranteeField;

        private DocumentReferenceType procurementLegislationDocumentReferenceField;

        private DocumentReferenceType fiscalLegislationDocumentReferenceField;

        private DocumentReferenceType environmentalLegislationDocumentReferenceField;

        private DocumentReferenceType employmentLegislationDocumentReferenceField;

        private DocumentReferenceType[] contractualDocumentReferenceField;

        private DocumentReferenceType callForTendersDocumentReferenceField;

        private PeriodType warrantyValidityPeriodField;

        private PaymentTermsType[] paymentTermsField;

        private TendererQualificationRequestType[] tendererQualificationRequestField;

        private SubcontractTermsType[] allowedSubcontractTermsField;

        private TenderPreparationType[] tenderPreparationField;

        private ContractExecutionRequirementType[] contractExecutionRequirementField;

        private AwardingTermsType awardingTermsField;

        private PartyType additionalInformationPartyField;

        private PartyType documentProviderPartyField;

        private PartyType tenderRecipientPartyField;

        private PartyType contractResponsiblePartyField;

        private PartyType[] tenderEvaluationPartyField;

        private PeriodType tenderValidityPeriodField;

        private PeriodType contractAcceptancePeriodField;

        private AppealTermsType appealTermsField;

        private LanguageType[] languageField;

        private BudgetAccountLineType[] budgetAccountLineField;

        private DocumentReferenceType replacedNoticeDocumentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AwardingMethodTypeCodeType AwardingMethodTypeCode
        {
            get
            {
                return awardingMethodTypeCodeField;
            }
            set
            {
                awardingMethodTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceEvaluationCodeType PriceEvaluationCode
        {
            get
            {
                return priceEvaluationCodeField;
            }
            set
            {
                priceEvaluationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumVariantQuantityType MaximumVariantQuantity
        {
            get
            {
                return maximumVariantQuantityField;
            }
            set
            {
                maximumVariantQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VariantConstraintIndicatorType VariantConstraintIndicator
        {
            get
            {
                return variantConstraintIndicatorField;
            }
            set
            {
                variantConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AcceptedVariantsDescriptionType[] AcceptedVariantsDescription
        {
            get
            {
                return acceptedVariantsDescriptionField;
            }
            set
            {
                acceptedVariantsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceRevisionFormulaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceRevisionFormulaDescriptionType[] PriceRevisionFormulaDescription
        {
            get
            {
                return priceRevisionFormulaDescriptionField;
            }
            set
            {
                priceRevisionFormulaDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FundingProgramCodeType FundingProgramCode
        {
            get
            {
                return fundingProgramCodeField;
            }
            set
            {
                fundingProgramCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FundingProgram", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FundingProgramType[] FundingProgram
        {
            get
            {
                return fundingProgramField;
            }
            set
            {
                fundingProgramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAdvertisementAmountType MaximumAdvertisementAmount
        {
            get
            {
                return maximumAdvertisementAmountField;
            }
            set
            {
                maximumAdvertisementAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentFrequencyCodeType PaymentFrequencyCode
        {
            get
            {
                return paymentFrequencyCodeField;
            }
            set
            {
                paymentFrequencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EconomicOperatorRegistryURIType EconomicOperatorRegistryURI
        {
            get
            {
                return economicOperatorRegistryURIField;
            }
            set
            {
                economicOperatorRegistryURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredCurriculaIndicatorType RequiredCurriculaIndicator
        {
            get
            {
                return requiredCurriculaIndicatorField;
            }
            set
            {
                requiredCurriculaIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OtherConditionsIndicatorType OtherConditionsIndicator
        {
            get
            {
                return otherConditionsIndicatorField;
            }
            set
            {
                otherConditionsIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalConditionsType[] AdditionalConditions
        {
            get
            {
                return additionalConditionsField;
            }
            set
            {
                additionalConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestSecurityClearanceDateType LatestSecurityClearanceDate
        {
            get
            {
                return latestSecurityClearanceDateField;
            }
            set
            {
                latestSecurityClearanceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentationFeeAmountType DocumentationFeeAmount
        {
            get
            {
                return documentationFeeAmountField;
            }
            set
            {
                documentationFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PenaltyClause")]
        public ClauseType[] PenaltyClause
        {
            get
            {
                return penaltyClauseField;
            }
            set
            {
                penaltyClauseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredFinancialGuarantee")]
        public FinancialGuaranteeType[] RequiredFinancialGuarantee
        {
            get
            {
                return requiredFinancialGuaranteeField;
            }
            set
            {
                requiredFinancialGuaranteeField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ProcurementLegislationDocumentReference
        {
            get
            {
                return procurementLegislationDocumentReferenceField;
            }
            set
            {
                procurementLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType FiscalLegislationDocumentReference
        {
            get
            {
                return fiscalLegislationDocumentReferenceField;
            }
            set
            {
                fiscalLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType EnvironmentalLegislationDocumentReference
        {
            get
            {
                return environmentalLegislationDocumentReferenceField;
            }
            set
            {
                environmentalLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType EmploymentLegislationDocumentReference
        {
            get
            {
                return employmentLegislationDocumentReferenceField;
            }
            set
            {
                employmentLegislationDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractualDocumentReference")]
        public DocumentReferenceType[] ContractualDocumentReference
        {
            get
            {
                return contractualDocumentReferenceField;
            }
            set
            {
                contractualDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CallForTendersDocumentReference
        {
            get
            {
                return callForTendersDocumentReferenceField;
            }
            set
            {
                callForTendersDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return warrantyValidityPeriodField;
            }
            set
            {
                warrantyValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return paymentTermsField;
            }
            set
            {
                paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TendererQualificationRequest")]
        public TendererQualificationRequestType[] TendererQualificationRequest
        {
            get
            {
                return tendererQualificationRequestField;
            }
            set
            {
                tendererQualificationRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedSubcontractTerms")]
        public SubcontractTermsType[] AllowedSubcontractTerms
        {
            get
            {
                return allowedSubcontractTermsField;
            }
            set
            {
                allowedSubcontractTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderPreparation")]
        public TenderPreparationType[] TenderPreparation
        {
            get
            {
                return tenderPreparationField;
            }
            set
            {
                tenderPreparationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractExecutionRequirement")]
        public ContractExecutionRequirementType[] ContractExecutionRequirement
        {
            get
            {
                return contractExecutionRequirementField;
            }
            set
            {
                contractExecutionRequirementField = value;
            }
        }

        /// <remarks/>
        public AwardingTermsType AwardingTerms
        {
            get
            {
                return awardingTermsField;
            }
            set
            {
                awardingTermsField = value;
            }
        }

        /// <remarks/>
        public PartyType AdditionalInformationParty
        {
            get
            {
                return additionalInformationPartyField;
            }
            set
            {
                additionalInformationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType DocumentProviderParty
        {
            get
            {
                return documentProviderPartyField;
            }
            set
            {
                documentProviderPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType TenderRecipientParty
        {
            get
            {
                return tenderRecipientPartyField;
            }
            set
            {
                tenderRecipientPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ContractResponsibleParty
        {
            get
            {
                return contractResponsiblePartyField;
            }
            set
            {
                contractResponsiblePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderEvaluationParty")]
        public PartyType[] TenderEvaluationParty
        {
            get
            {
                return tenderEvaluationPartyField;
            }
            set
            {
                tenderEvaluationPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType TenderValidityPeriod
        {
            get
            {
                return tenderValidityPeriodField;
            }
            set
            {
                tenderValidityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType ContractAcceptancePeriod
        {
            get
            {
                return contractAcceptancePeriodField;
            }
            set
            {
                contractAcceptancePeriodField = value;
            }
        }

        /// <remarks/>
        public AppealTermsType AppealTerms
        {
            get
            {
                return appealTermsField;
            }
            set
            {
                appealTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Language")]
        public LanguageType[] Language
        {
            get
            {
                return languageField;
            }
            set
            {
                languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BudgetAccountLine")]
        public BudgetAccountLineType[] BudgetAccountLine
        {
            get
            {
                return budgetAccountLineField;
            }
            set
            {
                budgetAccountLineField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ReplacedNoticeDocumentReference
        {
            get
            {
                return replacedNoticeDocumentReferenceField;
            }
            set
            {
                replacedNoticeDocumentReferenceField = value;
            }
        }
    }
}