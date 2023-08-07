using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
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
[XmlType(TypeName = "MeasureType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
public class MeasureType1 : MeasureType
{
}