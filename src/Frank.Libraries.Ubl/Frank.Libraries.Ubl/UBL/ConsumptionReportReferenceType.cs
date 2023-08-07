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
[XmlRoot("ConsumptionReportReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ConsumptionReportReferenceType
{
    private ConsumptionReportIDType consumptionReportIDField;

    private ConsumptionTypeCodeType consumptionTypeCodeField;

    private ConsumptionTypeType consumptionTypeField;

    private PeriodType periodField;

    private TotalConsumedQuantityType totalConsumedQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionReportIDType ConsumptionReportID
    {
        get => consumptionReportIDField;
        set => consumptionReportIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeType ConsumptionType
    {
        get => consumptionTypeField;
        set => consumptionTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeCodeType ConsumptionTypeCode
    {
        get => consumptionTypeCodeField;
        set => consumptionTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalConsumedQuantityType TotalConsumedQuantity
    {
        get => totalConsumedQuantityField;
        set => totalConsumedQuantityField = value;
    }

    /// <remarks />
    public PeriodType Period
    {
        get => periodField;
        set => periodField = value;
    }
}