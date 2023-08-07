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
[XmlRoot("ExceptionNotificationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ExceptionNotificationLineType
{
    private CollaborationPriorityCodeType collaborationPriorityCodeField;

    private ComparedValueMeasureType comparedValueMeasureField;

    private DescriptionType[] descriptionField;

    private DocumentReferenceType[] documentReferenceField;

    private PeriodType exceptionObservationPeriodField;

    private ExceptionStatusCodeType exceptionStatusCodeField;

    private ForecastExceptionType forecastExceptionField;

    private IDType idField;

    private NoteType[] noteField;

    private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

    private ResolutionCodeType resolutionCodeField;

    private SourceValueMeasureType sourceValueMeasureField;

    private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

    private ItemType supplyItemField;

    private VarianceQuantityType varianceQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
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
    public ExceptionStatusCodeType ExceptionStatusCode
    {
        get => exceptionStatusCodeField;
        set => exceptionStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CollaborationPriorityCodeType CollaborationPriorityCode
    {
        get => collaborationPriorityCodeField;
        set => collaborationPriorityCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResolutionCodeType ResolutionCode
    {
        get => resolutionCodeField;
        set => resolutionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ComparedValueMeasureType ComparedValueMeasure
    {
        get => comparedValueMeasureField;
        set => comparedValueMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SourceValueMeasureType SourceValueMeasure
    {
        get => sourceValueMeasureField;
        set => sourceValueMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VarianceQuantityType VarianceQuantity
    {
        get => varianceQuantityField;
        set => varianceQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
    {
        get => supplyChainActivityTypeCodeField;
        set => supplyChainActivityTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
    {
        get => performanceMetricTypeCodeField;
        set => performanceMetricTypeCodeField = value;
    }

    /// <remarks />
    public PeriodType ExceptionObservationPeriod
    {
        get => exceptionObservationPeriodField;
        set => exceptionObservationPeriodField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public ForecastExceptionType ForecastException
    {
        get => forecastExceptionField;
        set => forecastExceptionField = value;
    }

    /// <remarks />
    public ItemType SupplyItem
    {
        get => supplyItemField;
        set => supplyItemField = value;
    }
}