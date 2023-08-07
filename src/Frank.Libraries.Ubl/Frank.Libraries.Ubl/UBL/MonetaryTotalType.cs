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
[XmlRoot("AnticipatedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class MonetaryTotalType
{
    private AllowanceTotalAmountType allowanceTotalAmountField;

    private ChargeTotalAmountType chargeTotalAmountField;

    private LineExtensionAmountType lineExtensionAmountField;

    private PayableAlternativeAmountType payableAlternativeAmountField;

    private PayableAmountType payableAmountField;

    private PayableRoundingAmountType payableRoundingAmountField;

    private PrepaidAmountType prepaidAmountField;

    private TaxExclusiveAmountType taxExclusiveAmountField;

    private TaxInclusiveAmountType taxInclusiveAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount
    {
        get => lineExtensionAmountField;
        set => lineExtensionAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxExclusiveAmountType TaxExclusiveAmount
    {
        get => taxExclusiveAmountField;
        set => taxExclusiveAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxInclusiveAmountType TaxInclusiveAmount
    {
        get => taxInclusiveAmountField;
        set => taxInclusiveAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AllowanceTotalAmountType AllowanceTotalAmount
    {
        get => allowanceTotalAmountField;
        set => allowanceTotalAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeTotalAmountType ChargeTotalAmount
    {
        get => chargeTotalAmountField;
        set => chargeTotalAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrepaidAmountType PrepaidAmount
    {
        get => prepaidAmountField;
        set => prepaidAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayableRoundingAmountType PayableRoundingAmount
    {
        get => payableRoundingAmountField;
        set => payableRoundingAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayableAmountType PayableAmount
    {
        get => payableAmountField;
        set => payableAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayableAlternativeAmountType PayableAlternativeAmount
    {
        get => payableAlternativeAmountField;
        set => payableAlternativeAmountField = value;
    }
}