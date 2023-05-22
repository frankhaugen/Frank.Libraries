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
[XmlRoot("Consumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ConsumptionType
{
    private AllowanceChargeType[] allowanceChargeField;

    private EnergyWaterSupplyType energyWaterSupplyField;

    private MonetaryTotalType legalMonetaryTotalField;

    private PeriodType mainPeriodField;

    private TaxTotalType[] taxTotalField;

    private TelecommunicationsSupplyType telecommunicationsSupplyField;

    private UtilityStatementTypeCodeType utilityStatementTypeCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UtilityStatementTypeCodeType UtilityStatementTypeCode
    {
        get => utilityStatementTypeCodeField;
        set => utilityStatementTypeCodeField = value;
    }

    /// <remarks />
    public PeriodType MainPeriod
    {
        get => mainPeriodField;
        set => mainPeriodField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    public EnergyWaterSupplyType EnergyWaterSupply
    {
        get => energyWaterSupplyField;
        set => energyWaterSupplyField = value;
    }

    /// <remarks />
    public TelecommunicationsSupplyType TelecommunicationsSupply
    {
        get => telecommunicationsSupplyField;
        set => telecommunicationsSupplyField = value;
    }

    /// <remarks />
    public MonetaryTotalType LegalMonetaryTotal
    {
        get => legalMonetaryTotalField;
        set => legalMonetaryTotalField = value;
    }
}