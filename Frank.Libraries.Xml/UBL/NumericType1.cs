using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [XmlInclude(typeof(WeightNumericType))]
    [XmlInclude(typeof(SequenceNumericType))]
    [XmlInclude(typeof(ResidentOccupantsNumericType))]
    [XmlInclude(typeof(ReminderSequenceNumericType))]
    [XmlInclude(typeof(PackSizeNumericType))]
    [XmlInclude(typeof(OrderQuantityIncrementNumericType))]
    [XmlInclude(typeof(OrderIntervalDaysNumericType))]
    [XmlInclude(typeof(MultiplierFactorNumericType))]
    [XmlInclude(typeof(MinimumNumberNumericType))]
    [XmlInclude(typeof(MaximumPaymentInstructionsNumericType))]
    [XmlInclude(typeof(MaximumNumberNumericType))]
    [XmlInclude(typeof(MaximumCopiesNumericType))]
    [XmlInclude(typeof(LineNumberNumericType))]
    [XmlInclude(typeof(LineCountNumericType))]
    [XmlInclude(typeof(FrozenPeriodDaysNumericType))]
    [XmlInclude(typeof(CalculationSequenceNumericType))]
    [XmlInclude(typeof(BudgetYearNumericType))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(TypeName="NumericType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class NumericType1 : NumericType {
    }
}