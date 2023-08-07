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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("FinalFinancialGuarantee", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class FinancialGuaranteeType
{
    private AmountRateType amountRateField;

    private PeriodType constitutionPeriodField;

    private DescriptionType[] descriptionField;

    private GuaranteeTypeCodeType guaranteeTypeCodeField;

    private LiabilityAmountType liabilityAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GuaranteeTypeCodeType GuaranteeTypeCode
    {
        get => guaranteeTypeCodeField;
        set => guaranteeTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LiabilityAmountType LiabilityAmount
    {
        get => liabilityAmountField;
        set => liabilityAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AmountRateType AmountRate
    {
        get => amountRateField;
        set => amountRateField = value;
    }

    /// <remarks />
    public PeriodType ConstitutionPeriod
    {
        get => constitutionPeriodField;
        set => constitutionPeriodField = value;
    }
}