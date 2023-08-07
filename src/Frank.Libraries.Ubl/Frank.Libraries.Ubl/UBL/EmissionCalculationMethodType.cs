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
[XmlRoot("EmissionCalculationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EmissionCalculationMethodType
{
    private CalculationMethodCodeType calculationMethodCodeField;

    private FullnessIndicationCodeType fullnessIndicationCodeField;

    private LocationType1 measurementFromLocationField;

    private LocationType1 measurementToLocationField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CalculationMethodCodeType CalculationMethodCode
    {
        get => calculationMethodCodeField;
        set => calculationMethodCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FullnessIndicationCodeType FullnessIndicationCode
    {
        get => fullnessIndicationCodeField;
        set => fullnessIndicationCodeField = value;
    }

    /// <remarks />
    public LocationType1 MeasurementFromLocation
    {
        get => measurementFromLocationField;
        set => measurementFromLocationField = value;
    }

    /// <remarks />
    public LocationType1 MeasurementToLocation
    {
        get => measurementToLocationField;
        set => measurementToLocationField = value;
    }
}