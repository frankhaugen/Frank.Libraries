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
[XmlRoot("Stowage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class StowageType
{
    private LocationType[] locationField;

    private LocationIDType locationIDField;

    private DimensionType[] measurementDimensionField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LocationIDType LocationID
    {
        get => locationIDField;
        set => locationIDField = value;
    }

    /// <remarks />
    [XmlElement("Location", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LocationType[] Location
    {
        get => locationField;
        set => locationField = value;
    }

    /// <remarks />
    [XmlElement("MeasurementDimension")]
    public DimensionType[] MeasurementDimension
    {
        get => measurementDimensionField;
        set => measurementDimensionField = value;
    }
}