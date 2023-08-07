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
[XmlRoot("ItemInformationRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ItemInformationRequestLineType
{
    private ForecastTypeCodeType forecastTypeCodeField;

    private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

    private PeriodType[] periodField;

    private SalesItemType[] salesItemField;

    private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

    private TimeFrequencyCodeType timeFrequencyCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TimeFrequencyCodeType TimeFrequencyCode
    {
        get => timeFrequencyCodeField;
        set => timeFrequencyCodeField = value;
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
    public ForecastTypeCodeType ForecastTypeCode
    {
        get => forecastTypeCodeField;
        set => forecastTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
    {
        get => performanceMetricTypeCodeField;
        set => performanceMetricTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Period")]
    public PeriodType[] Period
    {
        get => periodField;
        set => periodField = value;
    }

    /// <remarks />
    [XmlElement("SalesItem")]
    public SalesItemType[] SalesItem
    {
        get => salesItemField;
        set => salesItemField = value;
    }
}