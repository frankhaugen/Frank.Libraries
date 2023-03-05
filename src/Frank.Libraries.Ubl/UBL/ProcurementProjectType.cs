using System;
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
[XmlRoot("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ProcurementProjectType
{
    private CommodityClassificationType[] additionalCommodityClassificationField;

    private ContractExtensionType contractExtensionField;

    private DescriptionType[] descriptionField;

    private EstimatedOverallContractQuantityType estimatedOverallContractQuantityField;

    private FeeDescriptionType[] feeDescriptionField;

    private IDType idField;

    private CommodityClassificationType mainCommodityClassificationField;

    private NameType1[] nameField;

    private NoteType[] noteField;

    private PeriodType plannedPeriodField;

    private ProcurementSubTypeCodeType procurementSubTypeCodeField;

    private ProcurementTypeCodeType procurementTypeCodeField;

    private QualityControlCodeType qualityControlCodeField;

    private LocationType1[] realizedLocationField;

    private RequestedDeliveryDateType requestedDeliveryDateField;

    private RequestedTenderTotalType requestedTenderTotalField;

    private RequestForTenderLineType[] requestForTenderLineField;

    private RequiredFeeAmountType requiredFeeAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1[] Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcurementTypeCodeType ProcurementTypeCode
    {
        get => procurementTypeCodeField;
        set => procurementTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcurementSubTypeCodeType ProcurementSubTypeCode
    {
        get => procurementSubTypeCodeField;
        set => procurementSubTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QualityControlCodeType QualityControlCode
    {
        get => qualityControlCodeField;
        set => qualityControlCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredFeeAmountType RequiredFeeAmount
    {
        get => requiredFeeAmountField;
        set => requiredFeeAmountField = value;
    }

    /// <remarks />
    [XmlElement("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FeeDescriptionType[] FeeDescription
    {
        get => feeDescriptionField;
        set => feeDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestedDeliveryDateType RequestedDeliveryDate
    {
        get => requestedDeliveryDateField;
        set => requestedDeliveryDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedOverallContractQuantityType EstimatedOverallContractQuantity
    {
        get => estimatedOverallContractQuantityField;
        set => estimatedOverallContractQuantityField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    public RequestedTenderTotalType RequestedTenderTotal
    {
        get => requestedTenderTotalField;
        set => requestedTenderTotalField = value;
    }

    /// <remarks />
    public CommodityClassificationType MainCommodityClassification
    {
        get => mainCommodityClassificationField;
        set => mainCommodityClassificationField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalCommodityClassification")]
    public CommodityClassificationType[] AdditionalCommodityClassification
    {
        get => additionalCommodityClassificationField;
        set => additionalCommodityClassificationField = value;
    }

    /// <remarks />
    [XmlElement("RealizedLocation")]
    public LocationType1[] RealizedLocation
    {
        get => realizedLocationField;
        set => realizedLocationField = value;
    }

    /// <remarks />
    public PeriodType PlannedPeriod
    {
        get => plannedPeriodField;
        set => plannedPeriodField = value;
    }

    /// <remarks />
    public ContractExtensionType ContractExtension
    {
        get => contractExtensionField;
        set => contractExtensionField = value;
    }

    /// <remarks />
    [XmlElement("RequestForTenderLine")]
    public RequestForTenderLineType[] RequestForTenderLine
    {
        get => requestForTenderLineField;
        set => requestForTenderLineField = value;
    }
}