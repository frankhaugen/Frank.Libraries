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
[XmlRoot("EnergyTaxReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EnergyTaxReportType
{
    private TaxEnergyAmountType taxEnergyAmountField;

    private TaxEnergyBalanceAmountType taxEnergyBalanceAmountField;

    private TaxEnergyOnAccountAmountType taxEnergyOnAccountAmountField;

    private TaxSchemeType taxSchemeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxEnergyAmountType TaxEnergyAmount
    {
        get => taxEnergyAmountField;
        set => taxEnergyAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxEnergyOnAccountAmountType TaxEnergyOnAccountAmount
    {
        get => taxEnergyOnAccountAmountField;
        set => taxEnergyOnAccountAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxEnergyBalanceAmountType TaxEnergyBalanceAmount
    {
        get => taxEnergyBalanceAmountField;
        set => taxEnergyBalanceAmountField = value;
    }

    /// <remarks />
    public TaxSchemeType TaxScheme
    {
        get => taxSchemeField;
        set => taxSchemeField = value;
    }
}