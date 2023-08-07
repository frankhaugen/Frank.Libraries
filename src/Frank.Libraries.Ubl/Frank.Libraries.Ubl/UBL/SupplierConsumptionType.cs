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
[XmlRoot("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class SupplierConsumptionType
{
    private ConsumptionType consumptionField;

    private ConsumptionLineType[] consumptionLineField;

    private ContractType contractField;

    private DescriptionType[] descriptionField;

    private PartyType utilityCustomerPartyField;

    private PartyType utilitySupplierPartyField;

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    public PartyType UtilitySupplierParty
    {
        get => utilitySupplierPartyField;
        set => utilitySupplierPartyField = value;
    }

    /// <remarks />
    public PartyType UtilityCustomerParty
    {
        get => utilityCustomerPartyField;
        set => utilityCustomerPartyField = value;
    }

    /// <remarks />
    public ConsumptionType Consumption
    {
        get => consumptionField;
        set => consumptionField = value;
    }

    /// <remarks />
    public ContractType Contract
    {
        get => contractField;
        set => contractField = value;
    }

    /// <remarks />
    [XmlElement("ConsumptionLine")]
    public ConsumptionLineType[] ConsumptionLine
    {
        get => consumptionLineField;
        set => consumptionLineField = value;
    }
}