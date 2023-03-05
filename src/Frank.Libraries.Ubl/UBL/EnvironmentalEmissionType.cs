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
[XmlRoot("EnvironmentalEmission", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EnvironmentalEmissionType
{
    private DescriptionType[] descriptionField;

    private EmissionCalculationMethodType[] emissionCalculationMethodField;

    private EnvironmentalEmissionTypeCodeType environmentalEmissionTypeCodeField;

    private ValueMeasureType valueMeasureField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EnvironmentalEmissionTypeCodeType EnvironmentalEmissionTypeCode
    {
        get => environmentalEmissionTypeCodeField;
        set => environmentalEmissionTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValueMeasureType ValueMeasure
    {
        get => valueMeasureField;
        set => valueMeasureField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("EmissionCalculationMethod")]
    public EmissionCalculationMethodType[] EmissionCalculationMethod
    {
        get => emissionCalculationMethodField;
        set => emissionCalculationMethodField = value;
    }
}