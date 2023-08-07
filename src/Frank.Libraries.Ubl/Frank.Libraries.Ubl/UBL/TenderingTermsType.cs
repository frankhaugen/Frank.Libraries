using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TenderingTermsType
{
    private AcceptedVariantsDescriptionType[] acceptedVariantsDescriptionField;

    private AdditionalConditionsType[] additionalConditionsField;

    private PartyType additionalInformationPartyField;

    private SubcontractTermsType[] allowedSubcontractTermsField;

    private AppealTermsType appealTermsField;

    private AwardingMethodTypeCodeType awardingMethodTypeCodeField;

    private AwardingTermsType awardingTermsField;

    private BudgetAccountLineType[] budgetAccountLineField;

    private DocumentReferenceType callForTendersDocumentReferenceField;

    private PeriodType contractAcceptancePeriodField;

    private ContractExecutionRequirementType[] contractExecutionRequirementField;

    private PartyType contractResponsiblePartyField;

    private DocumentReferenceType[] contractualDocumentReferenceField;

    private DocumentationFeeAmountType documentationFeeAmountField;

    private PartyType documentProviderPartyField;

    private EconomicOperatorRegistryURIType economicOperatorRegistryURIField;

    private DocumentReferenceType employmentLegislationDocumentReferenceField;

    private DocumentReferenceType environmentalLegislationDocumentReferenceField;

    private DocumentReferenceType fiscalLegislationDocumentReferenceField;

    private FundingProgramCodeType fundingProgramCodeField;

    private FundingProgramType[] fundingProgramField;

    private LanguageType[] languageField;

    private LatestSecurityClearanceDateType latestSecurityClearanceDateField;

    private MaximumAdvertisementAmountType maximumAdvertisementAmountField;

    private MaximumVariantQuantityType maximumVariantQuantityField;

    private NoteType[] noteField;

    private OtherConditionsIndicatorType otherConditionsIndicatorField;

    private PaymentFrequencyCodeType paymentFrequencyCodeField;

    private PaymentTermsType[] paymentTermsField;

    private ClauseType[] penaltyClauseField;

    private PriceEvaluationCodeType priceEvaluationCodeField;

    private PriceRevisionFormulaDescriptionType[] priceRevisionFormulaDescriptionField;

    private DocumentReferenceType procurementLegislationDocumentReferenceField;

    private DocumentReferenceType replacedNoticeDocumentReferenceField;

    private RequiredCurriculaIndicatorType requiredCurriculaIndicatorField;

    private FinancialGuaranteeType[] requiredFinancialGuaranteeField;

    private TendererQualificationRequestType[] tendererQualificationRequestField;

    private PartyType[] tenderEvaluationPartyField;

    private TenderPreparationType[] tenderPreparationField;

    private PartyType tenderRecipientPartyField;

    private PeriodType tenderValidityPeriodField;

    private VariantConstraintIndicatorType variantConstraintIndicatorField;

    private PeriodType warrantyValidityPeriodField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AwardingMethodTypeCodeType AwardingMethodTypeCode
    {
        get => awardingMethodTypeCodeField;
        set => awardingMethodTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceEvaluationCodeType PriceEvaluationCode
    {
        get => priceEvaluationCodeField;
        set => priceEvaluationCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumVariantQuantityType MaximumVariantQuantity
    {
        get => maximumVariantQuantityField;
        set => maximumVariantQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VariantConstraintIndicatorType VariantConstraintIndicator
    {
        get => variantConstraintIndicatorField;
        set => variantConstraintIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AcceptedVariantsDescriptionType[] AcceptedVariantsDescription
    {
        get => acceptedVariantsDescriptionField;
        set => acceptedVariantsDescriptionField = value;
    }

    /// <remarks />
    [XmlElement("PriceRevisionFormulaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceRevisionFormulaDescriptionType[] PriceRevisionFormulaDescription
    {
        get => priceRevisionFormulaDescriptionField;
        set => priceRevisionFormulaDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FundingProgramCodeType FundingProgramCode
    {
        get => fundingProgramCodeField;
        set => fundingProgramCodeField = value;
    }

    /// <remarks />
    [XmlElement("FundingProgram", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FundingProgramType[] FundingProgram
    {
        get => fundingProgramField;
        set => fundingProgramField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumAdvertisementAmountType MaximumAdvertisementAmount
    {
        get => maximumAdvertisementAmountField;
        set => maximumAdvertisementAmountField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentFrequencyCodeType PaymentFrequencyCode
    {
        get => paymentFrequencyCodeField;
        set => paymentFrequencyCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EconomicOperatorRegistryURIType EconomicOperatorRegistryURI
    {
        get => economicOperatorRegistryURIField;
        set => economicOperatorRegistryURIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredCurriculaIndicatorType RequiredCurriculaIndicator
    {
        get => requiredCurriculaIndicatorField;
        set => requiredCurriculaIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OtherConditionsIndicatorType OtherConditionsIndicator
    {
        get => otherConditionsIndicatorField;
        set => otherConditionsIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalConditionsType[] AdditionalConditions
    {
        get => additionalConditionsField;
        set => additionalConditionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestSecurityClearanceDateType LatestSecurityClearanceDate
    {
        get => latestSecurityClearanceDateField;
        set => latestSecurityClearanceDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentationFeeAmountType DocumentationFeeAmount
    {
        get => documentationFeeAmountField;
        set => documentationFeeAmountField = value;
    }

    /// <remarks />
    [XmlElement("PenaltyClause")]
    public ClauseType[] PenaltyClause
    {
        get => penaltyClauseField;
        set => penaltyClauseField = value;
    }

    /// <remarks />
    [XmlElement("RequiredFinancialGuarantee")]
    public FinancialGuaranteeType[] RequiredFinancialGuarantee
    {
        get => requiredFinancialGuaranteeField;
        set => requiredFinancialGuaranteeField = value;
    }

    /// <remarks />
    public DocumentReferenceType ProcurementLegislationDocumentReference
    {
        get => procurementLegislationDocumentReferenceField;
        set => procurementLegislationDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType FiscalLegislationDocumentReference
    {
        get => fiscalLegislationDocumentReferenceField;
        set => fiscalLegislationDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType EnvironmentalLegislationDocumentReference
    {
        get => environmentalLegislationDocumentReferenceField;
        set => environmentalLegislationDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType EmploymentLegislationDocumentReference
    {
        get => employmentLegislationDocumentReferenceField;
        set => employmentLegislationDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ContractualDocumentReference")]
    public DocumentReferenceType[] ContractualDocumentReference
    {
        get => contractualDocumentReferenceField;
        set => contractualDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType CallForTendersDocumentReference
    {
        get => callForTendersDocumentReferenceField;
        set => callForTendersDocumentReferenceField = value;
    }

    /// <remarks />
    public PeriodType WarrantyValidityPeriod
    {
        get => warrantyValidityPeriodField;
        set => warrantyValidityPeriodField = value;
    }

    /// <remarks />
    [XmlElement("PaymentTerms")]
    public PaymentTermsType[] PaymentTerms
    {
        get => paymentTermsField;
        set => paymentTermsField = value;
    }

    /// <remarks />
    [XmlElement("TendererQualificationRequest")]
    public TendererQualificationRequestType[] TendererQualificationRequest
    {
        get => tendererQualificationRequestField;
        set => tendererQualificationRequestField = value;
    }

    /// <remarks />
    [XmlElement("AllowedSubcontractTerms")]
    public SubcontractTermsType[] AllowedSubcontractTerms
    {
        get => allowedSubcontractTermsField;
        set => allowedSubcontractTermsField = value;
    }

    /// <remarks />
    [XmlElement("TenderPreparation")]
    public TenderPreparationType[] TenderPreparation
    {
        get => tenderPreparationField;
        set => tenderPreparationField = value;
    }

    /// <remarks />
    [XmlElement("ContractExecutionRequirement")]
    public ContractExecutionRequirementType[] ContractExecutionRequirement
    {
        get => contractExecutionRequirementField;
        set => contractExecutionRequirementField = value;
    }

    /// <remarks />
    public AwardingTermsType AwardingTerms
    {
        get => awardingTermsField;
        set => awardingTermsField = value;
    }

    /// <remarks />
    public PartyType AdditionalInformationParty
    {
        get => additionalInformationPartyField;
        set => additionalInformationPartyField = value;
    }

    /// <remarks />
    public PartyType DocumentProviderParty
    {
        get => documentProviderPartyField;
        set => documentProviderPartyField = value;
    }

    /// <remarks />
    public PartyType TenderRecipientParty
    {
        get => tenderRecipientPartyField;
        set => tenderRecipientPartyField = value;
    }

    /// <remarks />
    public PartyType ContractResponsibleParty
    {
        get => contractResponsiblePartyField;
        set => contractResponsiblePartyField = value;
    }

    /// <remarks />
    [XmlElement("TenderEvaluationParty")]
    public PartyType[] TenderEvaluationParty
    {
        get => tenderEvaluationPartyField;
        set => tenderEvaluationPartyField = value;
    }

    /// <remarks />
    public PeriodType TenderValidityPeriod
    {
        get => tenderValidityPeriodField;
        set => tenderValidityPeriodField = value;
    }

    /// <remarks />
    public PeriodType ContractAcceptancePeriod
    {
        get => contractAcceptancePeriodField;
        set => contractAcceptancePeriodField = value;
    }

    /// <remarks />
    public AppealTermsType AppealTerms
    {
        get => appealTermsField;
        set => appealTermsField = value;
    }

    /// <remarks />
    [XmlElement("Language")]
    public LanguageType[] Language
    {
        get => languageField;
        set => languageField = value;
    }

    /// <remarks />
    [XmlElement("BudgetAccountLine")]
    public BudgetAccountLineType[] BudgetAccountLine
    {
        get => budgetAccountLineField;
        set => budgetAccountLineField = value;
    }

    /// <remarks />
    public DocumentReferenceType ReplacedNoticeDocumentReference
    {
        get => replacedNoticeDocumentReferenceField;
        set => replacedNoticeDocumentReferenceField = value;
    }
}