using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[XmlInclude(typeof(MeasureType1))]
[XmlInclude(typeof(ValueMeasureType))]
[XmlInclude(typeof(TareWeightMeasureType))]
[XmlInclude(typeof(SourceValueMeasureType))]
[XmlInclude(typeof(PreEventNotificationDurationMeasureType))]
[XmlInclude(typeof(PostEventNotificationDurationMeasureType))]
[XmlInclude(typeof(NetWeightMeasureType))]
[XmlInclude(typeof(NetVolumeMeasureType))]
[XmlInclude(typeof(NetTonnageMeasureType))]
[XmlInclude(typeof(NetNetWeightMeasureType))]
[XmlInclude(typeof(MinimumMeasureType))]
[XmlInclude(typeof(MeasureType2))]
[XmlInclude(typeof(MaximumMeasureType))]
[XmlInclude(typeof(LongitudeMinutesMeasureType))]
[XmlInclude(typeof(LongitudeDegreesMeasureType))]
[XmlInclude(typeof(LoadingLengthMeasureType))]
[XmlInclude(typeof(LeadTimeMeasureType))]
[XmlInclude(typeof(LatitudeMinutesMeasureType))]
[XmlInclude(typeof(LatitudeDegreesMeasureType))]
[XmlInclude(typeof(GrossWeightMeasureType))]
[XmlInclude(typeof(GrossVolumeMeasureType))]
[XmlInclude(typeof(GrossTonnageMeasureType))]
[XmlInclude(typeof(DurationMeasureType))]
[XmlInclude(typeof(ComparedValueMeasureType))]
[XmlInclude(typeof(ChargeableWeightMeasureType))]
[XmlInclude(typeof(BaseUnitMeasureType))]
[XmlInclude(typeof(AltitudeMeasureType))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
public class MeasureType
{
    private string unitCodeField;

    private string unitCodeListVersionIDField;

    private decimal valueField;

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string unitCode
    {
        get => unitCodeField;
        set => unitCodeField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string unitCodeListVersionID
    {
        get => unitCodeListVersionIDField;
        set => unitCodeListVersionIDField = value;
    }

    /// <remarks />
    [XmlText]
    public decimal Value
    {
        get => valueField;
        set => valueField = value;
    }
}