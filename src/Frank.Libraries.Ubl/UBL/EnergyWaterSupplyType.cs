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
[XmlRoot("EnergyWaterSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EnergyWaterSupplyType
{
    private ConsumptionAverageType[] consumptionAverageField;

    private ConsumptionReportType[] consumptionReportField;

    private EnergyTaxReportType[] energyTaxReportField;

    private ConsumptionCorrectionType[] energyWaterConsumptionCorrectionField;

    /// <remarks />
    [XmlElement("ConsumptionReport")]
    public ConsumptionReportType[] ConsumptionReport
    {
        get => consumptionReportField;
        set => consumptionReportField = value;
    }

    /// <remarks />
    [XmlElement("EnergyTaxReport")]
    public EnergyTaxReportType[] EnergyTaxReport
    {
        get => energyTaxReportField;
        set => energyTaxReportField = value;
    }

    /// <remarks />
    [XmlElement("ConsumptionAverage")]
    public ConsumptionAverageType[] ConsumptionAverage
    {
        get => consumptionAverageField;
        set => consumptionAverageField = value;
    }

    /// <remarks />
    [XmlElement("EnergyWaterConsumptionCorrection")]
    public ConsumptionCorrectionType[] EnergyWaterConsumptionCorrection
    {
        get => energyWaterConsumptionCorrectionField;
        set => energyWaterConsumptionCorrectionField = value;
    }
}