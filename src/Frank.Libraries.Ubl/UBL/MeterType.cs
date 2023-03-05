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
[XmlRoot("Meter", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class MeterType
{
    private MeterConstantCodeType meterConstantCodeField;

    private MeterConstantType meterConstantField;

    private MeterNameType meterNameField;

    private MeterNumberType meterNumberField;

    private MeterPropertyType[] meterPropertyField;

    private MeterReadingType[] meterReadingField;

    private TotalDeliveredQuantityType totalDeliveredQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterNumberType MeterNumber
    {
        get => meterNumberField;
        set => meterNumberField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterNameType MeterName
    {
        get => meterNameField;
        set => meterNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterConstantType MeterConstant
    {
        get => meterConstantField;
        set => meterConstantField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MeterConstantCodeType MeterConstantCode
    {
        get => meterConstantCodeField;
        set => meterConstantCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalDeliveredQuantityType TotalDeliveredQuantity
    {
        get => totalDeliveredQuantityField;
        set => totalDeliveredQuantityField = value;
    }

    /// <remarks />
    [XmlElement("MeterReading")]
    public MeterReadingType[] MeterReading
    {
        get => meterReadingField;
        set => meterReadingField = value;
    }

    /// <remarks />
    [XmlElement("MeterProperty")]
    public MeterPropertyType[] MeterProperty
    {
        get => meterPropertyField;
        set => meterPropertyField = value;
    }
}