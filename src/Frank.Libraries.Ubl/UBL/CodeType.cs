using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[XmlInclude(typeof(CodeType1))]
[XmlInclude(typeof(ExtensionReasonCodeType))]
[XmlInclude(typeof(WorkPhaseCodeType))]
[XmlInclude(typeof(WeightingAlgorithmCodeType))]
[XmlInclude(typeof(WeekDayCodeType))]
[XmlInclude(typeof(ValidationResultCodeType))]
[XmlInclude(typeof(UtilityStatementTypeCodeType))]
[XmlInclude(typeof(UrgencyCodeType))]
[XmlInclude(typeof(UNDGCodeType))]
[XmlInclude(typeof(TypeCodeType))]
[XmlInclude(typeof(TransportationStatusTypeCodeType))]
[XmlInclude(typeof(TransportServiceCodeType))]
[XmlInclude(typeof(TransportModeCodeType))]
[XmlInclude(typeof(TransportMeansTypeCodeType))]
[XmlInclude(typeof(TransportHandlingUnitTypeCodeType))]
[XmlInclude(typeof(TransportExecutionStatusCodeType))]
[XmlInclude(typeof(TransportEventTypeCodeType))]
[XmlInclude(typeof(TransportEquipmentTypeCodeType))]
[XmlInclude(typeof(TransportEmergencyCardCodeType))]
[XmlInclude(typeof(TransportAuthorizationCodeType))]
[XmlInclude(typeof(TransitDirectionCodeType))]
[XmlInclude(typeof(TradeServiceCodeType))]
[XmlInclude(typeof(TradeItemPackingLabelingTypeCodeType))]
[XmlInclude(typeof(TrackingDeviceCodeType))]
[XmlInclude(typeof(TimingComplaintCodeType))]
[XmlInclude(typeof(TimeFrequencyCodeType))]
[XmlInclude(typeof(ThresholdValueComparisonCodeType))]
[XmlInclude(typeof(TendererRoleCodeType))]
[XmlInclude(typeof(TendererRequirementTypeCodeType))]
[XmlInclude(typeof(TenderTypeCodeType))]
[XmlInclude(typeof(TenderResultCodeType))]
[XmlInclude(typeof(TenderEnvelopeTypeCodeType))]
[XmlInclude(typeof(TelecommunicationsSupplyTypeCodeType))]
[XmlInclude(typeof(TelecommunicationsServiceCategoryCodeType))]
[XmlInclude(typeof(TelecommunicationsServiceCallCodeType))]
[XmlInclude(typeof(TaxTypeCodeType))]
[XmlInclude(typeof(TaxLevelCodeType))]
[XmlInclude(typeof(TaxExemptionReasonCodeType))]
[XmlInclude(typeof(TaxCurrencyCodeType))]
[XmlInclude(typeof(TariffCodeType))]
[XmlInclude(typeof(TariffClassCodeType))]
[XmlInclude(typeof(TargetCurrencyCodeType))]
[XmlInclude(typeof(SupplyChainActivityTypeCodeType))]
[XmlInclude(typeof(SubstitutionStatusCodeType))]
[XmlInclude(typeof(SubscriberTypeCodeType))]
[XmlInclude(typeof(SubmissionMethodCodeType))]
[XmlInclude(typeof(SubcontractingConditionsCodeType))]
[XmlInclude(typeof(StatusReasonCodeType))]
[XmlInclude(typeof(StatusCodeType))]
[XmlInclude(typeof(StatementTypeCodeType))]
[XmlInclude(typeof(SpecificationTypeCodeType))]
[XmlInclude(typeof(SourceCurrencyCodeType))]
[XmlInclude(typeof(SizeTypeCodeType))]
[XmlInclude(typeof(ShortageActionCodeType))]
[XmlInclude(typeof(ShippingPriorityLevelCodeType))]
[XmlInclude(typeof(ServiceTypeCodeType))]
[XmlInclude(typeof(ServiceInformationPreferenceCodeType))]
[XmlInclude(typeof(SecurityClassificationCodeType))]
[XmlInclude(typeof(SealStatusCodeType))]
[XmlInclude(typeof(SealIssuerTypeCodeType))]
[XmlInclude(typeof(RoleCodeType))]
[XmlInclude(typeof(RevisionStatusCodeType))]
[XmlInclude(typeof(RetailEventStatusCodeType))]
[XmlInclude(typeof(ResponseCodeType))]
[XmlInclude(typeof(ResolutionCodeType))]
[XmlInclude(typeof(ResidenceTypeCodeType))]
[XmlInclude(typeof(RequestedInvoiceCurrencyCodeType))]
[XmlInclude(typeof(ReminderTypeCodeType))]
[XmlInclude(typeof(RejectReasonCodeType))]
[XmlInclude(typeof(RejectActionCodeType))]
[XmlInclude(typeof(ReferenceEventCodeType))]
[XmlInclude(typeof(ReceiptAdviceTypeCodeType))]
[XmlInclude(typeof(QuantityDiscrepancyCodeType))]
[XmlInclude(typeof(QualityControlCodeType))]
[XmlInclude(typeof(PurposeCodeType))]
[XmlInclude(typeof(ProviderTypeCodeType))]
[XmlInclude(typeof(PromotionalEventTypeCodeType))]
[XmlInclude(typeof(ProfileStatusCodeType))]
[XmlInclude(typeof(ProcurementTypeCodeType))]
[XmlInclude(typeof(ProcurementSubTypeCodeType))]
[XmlInclude(typeof(ProcessReasonCodeType))]
[XmlInclude(typeof(ProcedureCodeType))]
[XmlInclude(typeof(PrivacyCodeType))]
[XmlInclude(typeof(PricingCurrencyCodeType))]
[XmlInclude(typeof(PriceTypeCodeType))]
[XmlInclude(typeof(PriceEvaluationCodeType))]
[XmlInclude(typeof(PreviousMeterReadingMethodCodeType))]
[XmlInclude(typeof(PreviousCancellationReasonCodeType))]
[XmlInclude(typeof(PreferenceCriterionCodeType))]
[XmlInclude(typeof(PositionCodeType))]
[XmlInclude(typeof(PerformanceMetricTypeCodeType))]
[XmlInclude(typeof(PaymentPurposeCodeType))]
[XmlInclude(typeof(PaymentMeansCodeType))]
[XmlInclude(typeof(PaymentFrequencyCodeType))]
[XmlInclude(typeof(PaymentCurrencyCodeType))]
[XmlInclude(typeof(PaymentChannelCodeType))]
[XmlInclude(typeof(PaymentAlternativeCurrencyCodeType))]
[XmlInclude(typeof(PartyTypeCodeType))]
[XmlInclude(typeof(PartPresentationCodeType))]
[XmlInclude(typeof(ParentDocumentTypeCodeType))]
[XmlInclude(typeof(PackingCriteriaCodeType))]
[XmlInclude(typeof(PackagingTypeCodeType))]
[XmlInclude(typeof(PackageLevelCodeType))]
[XmlInclude(typeof(PackLevelCodeType))]
[XmlInclude(typeof(OwnerTypeCodeType))]
[XmlInclude(typeof(OrderTypeCodeType))]
[XmlInclude(typeof(OrderResponseCodeType))]
[XmlInclude(typeof(OneTimeChargeTypeCodeType))]
[XmlInclude(typeof(NotificationTypeCodeType))]
[XmlInclude(typeof(NatureCodeType))]
[XmlInclude(typeof(NameCodeType))]
[XmlInclude(typeof(MiscellaneousEventTypeCodeType))]
[XmlInclude(typeof(MimeCodeType))]
[XmlInclude(typeof(MeterReadingTypeCodeType))]
[XmlInclude(typeof(MeterConstantCodeType))]
[XmlInclude(typeof(MedicalFirstAidGuideCodeType))]
[XmlInclude(typeof(MathematicOperatorCodeType))]
[XmlInclude(typeof(MandateTypeCodeType))]
[XmlInclude(typeof(LossRiskResponsibilityCodeType))]
[XmlInclude(typeof(LongitudeDirectionCodeType))]
[XmlInclude(typeof(LocationTypeCodeType))]
[XmlInclude(typeof(LocaleCodeType))]
[XmlInclude(typeof(LineStatusCodeType))]
[XmlInclude(typeof(LifeCycleStatusCodeType))]
[XmlInclude(typeof(LatitudeDirectionCodeType))]
[XmlInclude(typeof(LatestMeterReadingMethodCodeType))]
[XmlInclude(typeof(ItemClassificationCodeType))]
[XmlInclude(typeof(InvoiceTypeCodeType))]
[XmlInclude(typeof(InspectionMethodCodeType))]
[XmlInclude(typeof(InhalationToxicityZoneCodeType))]
[XmlInclude(typeof(IndustryClassificationCodeType))]
[XmlInclude(typeof(ImportanceCodeType))]
[XmlInclude(typeof(IdentificationCodeType))]
[XmlInclude(typeof(HeatingTypeCodeType))]
[XmlInclude(typeof(HazardousRegulationCodeType))]
[XmlInclude(typeof(HazardousCategoryCodeType))]
[XmlInclude(typeof(HandlingCodeType))]
[XmlInclude(typeof(GuaranteeTypeCodeType))]
[XmlInclude(typeof(GenderCodeType))]
[XmlInclude(typeof(FundingProgramCodeType))]
[XmlInclude(typeof(FullnessIndicationCodeType))]
[XmlInclude(typeof(FreightRateClassCodeType))]
[XmlInclude(typeof(FormatCodeType))]
[XmlInclude(typeof(ForecastTypeCodeType))]
[XmlInclude(typeof(ForecastPurposeCodeType))]
[XmlInclude(typeof(FinancingInstrumentCodeType))]
[XmlInclude(typeof(FeatureTacticTypeCodeType))]
[XmlInclude(typeof(ExpressionCodeType))]
[XmlInclude(typeof(ExpenseCodeType))]
[XmlInclude(typeof(ExemptionReasonCodeType))]
[XmlInclude(typeof(ExecutionRequirementCodeType))]
[XmlInclude(typeof(ExceptionStatusCodeType))]
[XmlInclude(typeof(ExceptionResolutionCodeType))]
[XmlInclude(typeof(EvidenceTypeCodeType))]
[XmlInclude(typeof(EvaluationCriterionTypeCodeType))]
[XmlInclude(typeof(EnvironmentalEmissionTypeCodeType))]
[XmlInclude(typeof(EncodingCodeType))]
[XmlInclude(typeof(EmergencyProceduresCodeType))]
[XmlInclude(typeof(DutyCodeType))]
[XmlInclude(typeof(DocumentTypeCodeType))]
[XmlInclude(typeof(DocumentStatusReasonCodeType))]
[XmlInclude(typeof(DocumentStatusCodeType))]
[XmlInclude(typeof(DocumentCurrencyCodeType))]
[XmlInclude(typeof(DispositionCodeType))]
[XmlInclude(typeof(DisplayTacticTypeCodeType))]
[XmlInclude(typeof(DirectionCodeType))]
[XmlInclude(typeof(DespatchAdviceTypeCodeType))]
[XmlInclude(typeof(DescriptionCodeType))]
[XmlInclude(typeof(DeclarationTypeCodeType))]
[XmlInclude(typeof(DataSourceCodeType))]
[XmlInclude(typeof(CustomsStatusCodeType))]
[XmlInclude(typeof(CurrentChargeTypeCodeType))]
[XmlInclude(typeof(CurrencyCodeType))]
[XmlInclude(typeof(CreditNoteTypeCodeType))]
[XmlInclude(typeof(CountrySubentityCodeType))]
[XmlInclude(typeof(CorrectionTypeCodeType))]
[XmlInclude(typeof(CorporateRegistrationTypeCodeType))]
[XmlInclude(typeof(CoordinateSystemCodeType))]
[XmlInclude(typeof(ContractingSystemCodeType))]
[XmlInclude(typeof(ContractTypeCodeType))]
[XmlInclude(typeof(ConsumptionTypeCodeType))]
[XmlInclude(typeof(ConsumptionLevelCodeType))]
[XmlInclude(typeof(ConsumersEnergyLevelCodeType))]
[XmlInclude(typeof(ConsumerIncentiveTacticTypeCodeType))]
[XmlInclude(typeof(ConstitutionCodeType))]
[XmlInclude(typeof(ConditionCodeType))]
[XmlInclude(typeof(ComparisonDataSourceCodeType))]
[XmlInclude(typeof(ComparisonDataCodeType))]
[XmlInclude(typeof(CompanyLiquidationStatusCodeType))]
[XmlInclude(typeof(CompanyLegalFormCodeType))]
[XmlInclude(typeof(CommodityCodeType))]
[XmlInclude(typeof(CollaborationPriorityCodeType))]
[XmlInclude(typeof(CharacterSetCodeType))]
[XmlInclude(typeof(ChannelCodeType))]
[XmlInclude(typeof(CertificateTypeCodeType))]
[XmlInclude(typeof(CargoTypeCodeType))]
[XmlInclude(typeof(CardTypeCodeType))]
[XmlInclude(typeof(CardChipCodeType))]
[XmlInclude(typeof(CapabilityTypeCodeType))]
[XmlInclude(typeof(CalculationMethodCodeType))]
[XmlInclude(typeof(CalculationExpressionCodeType))]
[XmlInclude(typeof(AwardingMethodTypeCodeType))]
[XmlInclude(typeof(AwardingCriterionTypeCodeType))]
[XmlInclude(typeof(AvailabilityStatusCodeType))]
[XmlInclude(typeof(ApplicationStatusCodeType))]
[XmlInclude(typeof(AllowanceChargeReasonCodeType))]
[XmlInclude(typeof(AdmissionCodeType))]
[XmlInclude(typeof(AdjustmentReasonCodeType))]
[XmlInclude(typeof(AddressTypeCodeType))]
[XmlInclude(typeof(AddressFormatCodeType))]
[XmlInclude(typeof(ActivityTypeCodeType))]
[XmlInclude(typeof(ActionCodeType))]
[XmlInclude(typeof(AccountingCostCodeType))]
[XmlInclude(typeof(AccountTypeCodeType))]
[XmlInclude(typeof(AccountFormatCodeType))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
public class CodeType
{
    private string languageIDField;

    private string listAgencyIDField;

    private string listAgencyNameField;

    private string listIDField;

    private string listNameField;

    private string listSchemeURIField;

    private string listURIField;

    private string listVersionIDField;

    private string nameField;

    private string valueField;

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string listID
    {
        get => listIDField;
        set => listIDField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string listAgencyID
    {
        get => listAgencyIDField;
        set => listAgencyIDField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string listAgencyName
    {
        get => listAgencyNameField;
        set => listAgencyNameField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string listName
    {
        get => listNameField;
        set => listNameField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string listVersionID
    {
        get => listVersionIDField;
        set => listVersionIDField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "language")]
    public string languageID
    {
        get => languageIDField;
        set => languageIDField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string listURI
    {
        get => listURIField;
        set => listURIField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string listSchemeURI
    {
        get => listSchemeURIField;
        set => listSchemeURIField = value;
    }

    /// <remarks />
    [XmlText(DataType = "normalizedString")]
    public string Value
    {
        get => valueField;
        set => valueField = value;
    }
}