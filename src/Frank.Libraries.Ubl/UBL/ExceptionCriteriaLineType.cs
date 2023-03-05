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
[XmlRoot("ExceptionCriteriaLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ExceptionCriteriaLineType
{
    private CollaborationPriorityCodeType collaborationPriorityCodeField;

    private PeriodType effectivePeriodField;

    private ExceptionResolutionCodeType exceptionResolutionCodeField;

    private ExceptionStatusCodeType exceptionStatusCodeField;

    private ForecastExceptionCriterionLineType forecastExceptionCriterionLineField;

    private IDType idField;

    private NoteType[] noteField;

    private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

    private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

    private ItemType[] supplyItemField;

    private ThresholdQuantityType thresholdQuantityField;

    private ThresholdValueComparisonCodeType thresholdValueComparisonCodeField;

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
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThresholdValueComparisonCodeType ThresholdValueComparisonCode
    {
        get => thresholdValueComparisonCodeField;
        set => thresholdValueComparisonCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThresholdQuantityType ThresholdQuantity
    {
        get => thresholdQuantityField;
        set => thresholdQuantityField = value;
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
    public ExceptionResolutionCodeType ExceptionResolutionCode
    {
        get => exceptionResolutionCodeField;
        set => exceptionResolutionCodeField = value;
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
    public PeriodType EffectivePeriod
    {
        get => effectivePeriodField;
        set => effectivePeriodField = value;
    }

    /// <remarks />
    [XmlElement("SupplyItem")]
    public ItemType[] SupplyItem
    {
        get => supplyItemField;
        set => supplyItemField = value;
    }

    /// <remarks />
    public ForecastExceptionCriterionLineType ForecastExceptionCriterionLine
    {
        get => forecastExceptionCriterionLineField;
        set => forecastExceptionCriterionLineField = value;
    }
}