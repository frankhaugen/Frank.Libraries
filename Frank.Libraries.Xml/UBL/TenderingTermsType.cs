using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("TenderingTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TenderingTermsType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AwardingMethodTypeCodeType AwardingMethodTypeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceEvaluationCodeType PriceEvaluationCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumVariantQuantityType MaximumVariantQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VariantConstraintIndicatorType VariantConstraintIndicator;
    
        /// <remarks/>
        [XmlElement("AcceptedVariantsDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AcceptedVariantsDescriptionType[] AcceptedVariantsDescription;
    
        /// <remarks/>
        [XmlElement("PriceRevisionFormulaDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceRevisionFormulaDescriptionType[] PriceRevisionFormulaDescription;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FundingProgramCodeType FundingProgramCode;
    
        /// <remarks/>
        [XmlElement("FundingProgram", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FundingProgramType[] FundingProgram;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAdvertisementAmountType MaximumAdvertisementAmount;
    
        /// <remarks/>
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentFrequencyCodeType PaymentFrequencyCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EconomicOperatorRegistryURIType EconomicOperatorRegistryURI;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredCurriculaIndicatorType RequiredCurriculaIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OtherConditionsIndicatorType OtherConditionsIndicator;
    
        /// <remarks/>
        [XmlElement("AdditionalConditions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalConditionsType[] AdditionalConditions;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestSecurityClearanceDateType LatestSecurityClearanceDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentationFeeAmountType DocumentationFeeAmount;
    
        /// <remarks/>
        [XmlElement("PenaltyClause")]
        public ClauseType[] PenaltyClause;
    
        /// <remarks/>
        [XmlElement("RequiredFinancialGuarantee")]
        public FinancialGuaranteeType[] RequiredFinancialGuarantee;
    
        /// <remarks/>
        public DocumentReferenceType ProcurementLegislationDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType FiscalLegislationDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType EnvironmentalLegislationDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType EmploymentLegislationDocumentReference;
    
        /// <remarks/>
        [XmlElement("ContractualDocumentReference")]
        public DocumentReferenceType[] ContractualDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType CallForTendersDocumentReference;
    
        /// <remarks/>
        public PeriodType WarrantyValidityPeriod;
    
        /// <remarks/>
        [XmlElement("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms;
    
        /// <remarks/>
        [XmlElement("TendererQualificationRequest")]
        public TendererQualificationRequestType[] TendererQualificationRequest;
    
        /// <remarks/>
        [XmlElement("AllowedSubcontractTerms")]
        public SubcontractTermsType[] AllowedSubcontractTerms;
    
        /// <remarks/>
        [XmlElement("TenderPreparation")]
        public TenderPreparationType[] TenderPreparation;
    
        /// <remarks/>
        [XmlElement("ContractExecutionRequirement")]
        public ContractExecutionRequirementType[] ContractExecutionRequirement;
    
        /// <remarks/>
        public AwardingTermsType AwardingTerms;
    
        /// <remarks/>
        public PartyType AdditionalInformationParty;
    
        /// <remarks/>
        public PartyType DocumentProviderParty;
    
        /// <remarks/>
        public PartyType TenderRecipientParty;
    
        /// <remarks/>
        public PartyType ContractResponsibleParty;
    
        /// <remarks/>
        [XmlElement("TenderEvaluationParty")]
        public PartyType[] TenderEvaluationParty;
    
        /// <remarks/>
        public PeriodType TenderValidityPeriod;
    
        /// <remarks/>
        public PeriodType ContractAcceptancePeriod;
    
        /// <remarks/>
        public AppealTermsType AppealTerms;
    
        /// <remarks/>
        [XmlElement("Language")]
        public LanguageType[] Language;
    
        /// <remarks/>
        [XmlElement("BudgetAccountLine")]
        public BudgetAccountLineType[] BudgetAccountLine;
    
        /// <remarks/>
        public DocumentReferenceType ReplacedNoticeDocumentReference;
    }
}