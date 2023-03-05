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
[XmlRoot("LocationCoordinate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class LocationCoordinateType
{
    private AltitudeMeasureType altitudeMeasureField;

    private CoordinateSystemCodeType coordinateSystemCodeField;

    private LatitudeDegreesMeasureType latitudeDegreesMeasureField;

    private LatitudeDirectionCodeType latitudeDirectionCodeField;

    private LatitudeMinutesMeasureType latitudeMinutesMeasureField;

    private LongitudeDegreesMeasureType longitudeDegreesMeasureField;

    private LongitudeDirectionCodeType longitudeDirectionCodeField;

    private LongitudeMinutesMeasureType longitudeMinutesMeasureField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CoordinateSystemCodeType CoordinateSystemCode
    {
        get => coordinateSystemCodeField;
        set => coordinateSystemCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatitudeDegreesMeasureType LatitudeDegreesMeasure
    {
        get => latitudeDegreesMeasureField;
        set => latitudeDegreesMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatitudeMinutesMeasureType LatitudeMinutesMeasure
    {
        get => latitudeMinutesMeasureField;
        set => latitudeMinutesMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatitudeDirectionCodeType LatitudeDirectionCode
    {
        get => latitudeDirectionCodeField;
        set => latitudeDirectionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LongitudeDegreesMeasureType LongitudeDegreesMeasure
    {
        get => longitudeDegreesMeasureField;
        set => longitudeDegreesMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LongitudeMinutesMeasureType LongitudeMinutesMeasure
    {
        get => longitudeMinutesMeasureField;
        set => longitudeMinutesMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LongitudeDirectionCodeType LongitudeDirectionCode
    {
        get => longitudeDirectionCodeField;
        set => longitudeDirectionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AltitudeMeasureType AltitudeMeasure
    {
        get => altitudeMeasureField;
        set => altitudeMeasureField = value;
    }
}