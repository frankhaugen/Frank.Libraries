using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[XmlInclude(typeof(TierRatePercentType))]
[XmlInclude(typeof(TargetServicePercentType))]
[XmlInclude(typeof(SettlementDiscountPercentType))]
[XmlInclude(typeof(ReliabilityPercentType))]
[XmlInclude(typeof(ProgressPercentType))]
[XmlInclude(typeof(PercentType1))]
[XmlInclude(typeof(PenaltySurchargePercentType))]
[XmlInclude(typeof(PaymentPercentType))]
[XmlInclude(typeof(ParticipationPercentType))]
[XmlInclude(typeof(PartecipationPercentType))]
[XmlInclude(typeof(MinimumPercentType))]
[XmlInclude(typeof(MaximumPercentType))]
[XmlInclude(typeof(HumidityPercentType))]
[XmlInclude(typeof(AirFlowPercentType))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
public class PercentType : NumericType
{
}