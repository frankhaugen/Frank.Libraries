using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(TypeName = "DutyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("CallDuty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DutyType1
{
    private AmountType2 amountField;

    private DutyCodeType dutyCodeField;

    private DutyType dutyField;

    private TaxCategoryType taxCategoryField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AmountType2 Amount
    {
        get => amountField;
        set => amountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DutyType Duty
    {
        get => dutyField;
        set => dutyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DutyCodeType DutyCode
    {
        get => dutyCodeField;
        set => dutyCodeField = value;
    }

    /// <remarks />
    public TaxCategoryType TaxCategory
    {
        get => taxCategoryField;
        set => taxCategoryField = value;
    }
}