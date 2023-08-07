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
[XmlRoot("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TaxTotalType
{
    private RoundingAmountType roundingAmountField;

    private TaxAmountType taxAmountField;

    private TaxEvidenceIndicatorType taxEvidenceIndicatorField;

    private TaxIncludedIndicatorType taxIncludedIndicatorField;

    private TaxSubtotalType[] taxSubtotalField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxAmountType TaxAmount
    {
        get => taxAmountField;
        set => taxAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RoundingAmountType RoundingAmount
    {
        get => roundingAmountField;
        set => roundingAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxEvidenceIndicatorType TaxEvidenceIndicator
    {
        get => taxEvidenceIndicatorField;
        set => taxEvidenceIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxIncludedIndicatorType TaxIncludedIndicator
    {
        get => taxIncludedIndicatorField;
        set => taxIncludedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("TaxSubtotal")]
    public TaxSubtotalType[] TaxSubtotal
    {
        get => taxSubtotalField;
        set => taxSubtotalField = value;
    }
}