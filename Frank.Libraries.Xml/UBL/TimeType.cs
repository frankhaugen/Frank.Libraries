using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [XmlInclude(typeof(ValidationTimeType))]
    [XmlInclude(typeof(StartTimeType))]
    [XmlInclude(typeof(SourceForecastIssueTimeType))]
    [XmlInclude(typeof(RevisionTimeType))]
    [XmlInclude(typeof(ResponseTimeType))]
    [XmlInclude(typeof(ResolutionTimeType))]
    [XmlInclude(typeof(RequiredDeliveryTimeType))]
    [XmlInclude(typeof(RequestedDespatchTimeType))]
    [XmlInclude(typeof(RegisteredTimeType))]
    [XmlInclude(typeof(ReferenceTimeType))]
    [XmlInclude(typeof(PaidTimeType))]
    [XmlInclude(typeof(OccurrenceTimeType))]
    [XmlInclude(typeof(NominationTimeType))]
    [XmlInclude(typeof(ManufactureTimeType))]
    [XmlInclude(typeof(LatestPickupTimeType))]
    [XmlInclude(typeof(LatestDeliveryTimeType))]
    [XmlInclude(typeof(LastRevisionTimeType))]
    [XmlInclude(typeof(IssueTimeType))]
    [XmlInclude(typeof(GuaranteedDespatchTimeType))]
    [XmlInclude(typeof(ExpiryTimeType))]
    [XmlInclude(typeof(EstimatedDespatchTimeType))]
    [XmlInclude(typeof(EstimatedDeliveryTimeType))]
    [XmlInclude(typeof(EndTimeType))]
    [XmlInclude(typeof(EffectiveTimeType))]
    [XmlInclude(typeof(EarliestPickupTimeType))]
    [XmlInclude(typeof(ComparisonForecastIssueTimeType))]
    [XmlInclude(typeof(CallTimeType))]
    [XmlInclude(typeof(AwardTimeType))]
    [XmlInclude(typeof(ActualPickupTimeType))]
    [XmlInclude(typeof(ActualDespatchTimeType))]
    [XmlInclude(typeof(ActualDeliveryTimeType))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class TimeType {
    
        /// <remarks/>
        [XmlText(DataType="time")]
        public DateTime Value;
    }
}