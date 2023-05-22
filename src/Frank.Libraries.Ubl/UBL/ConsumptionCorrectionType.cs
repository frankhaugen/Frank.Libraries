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
[XmlRoot("ConsumptionCorrection", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ConsumptionCorrectionType
{
    private ActualTemperatureReductionQuantityType actualTemperatureReductionQuantityField;

    private ConsumptionEnergyQuantityType consumptionEnergyQuantityField;

    private ConsumptionWaterQuantityType consumptionWaterQuantityField;

    private CorrectionAmountType correctionAmountField;

    private CorrectionTypeCodeType correctionTypeCodeField;

    private CorrectionTypeType correctionTypeField;

    private CorrectionUnitAmountType correctionUnitAmountField;

    private DescriptionType[] descriptionField;

    private DifferenceTemperatureReductionQuantityType differenceTemperatureReductionQuantityField;

    private GasPressureQuantityType gasPressureQuantityField;

    private MeterNumberType meterNumberField;

    private NormalTemperatureReductionQuantityType normalTemperatureReductionQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CorrectionTypeType CorrectionType
    {
        get => correctionTypeField;
        set => correctionTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CorrectionTypeCodeType CorrectionTypeCode
    {
        get => correctionTypeCodeField;
        set => correctionTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterNumberType MeterNumber
    {
        get => meterNumberField;
        set => meterNumberField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GasPressureQuantityType GasPressureQuantity
    {
        get => gasPressureQuantityField;
        set => gasPressureQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualTemperatureReductionQuantityType ActualTemperatureReductionQuantity
    {
        get => actualTemperatureReductionQuantityField;
        set => actualTemperatureReductionQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NormalTemperatureReductionQuantityType NormalTemperatureReductionQuantity
    {
        get => normalTemperatureReductionQuantityField;
        set => normalTemperatureReductionQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DifferenceTemperatureReductionQuantityType DifferenceTemperatureReductionQuantity
    {
        get => differenceTemperatureReductionQuantityField;
        set => differenceTemperatureReductionQuantityField = value;
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
    public CorrectionUnitAmountType CorrectionUnitAmount
    {
        get => correctionUnitAmountField;
        set => correctionUnitAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionEnergyQuantityType ConsumptionEnergyQuantity
    {
        get => consumptionEnergyQuantityField;
        set => consumptionEnergyQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionWaterQuantityType ConsumptionWaterQuantity
    {
        get => consumptionWaterQuantityField;
        set => consumptionWaterQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CorrectionAmountType CorrectionAmount
    {
        get => correctionAmountField;
        set => correctionAmountField = value;
    }
}