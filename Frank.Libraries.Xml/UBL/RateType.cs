using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [XmlInclude(typeof(TargetCurrencyBaseRateType))]
    [XmlInclude(typeof(SourceCurrencyBaseRateType))]
    [XmlInclude(typeof(RateType1))]
    [XmlInclude(typeof(OrderableUnitFactorRateType))]
    [XmlInclude(typeof(CalculationRateType))]
    [XmlInclude(typeof(AmountRateType))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class RateType : NumericType {
    }
}