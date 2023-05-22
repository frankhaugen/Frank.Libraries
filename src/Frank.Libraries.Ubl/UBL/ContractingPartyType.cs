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
[XmlRoot("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ContractingPartyType
{
    private BuyerProfileURIType buyerProfileURIField;

    private ContractingActivityType[] contractingActivityField;

    private ContractingPartyTypeType[] contractingPartyType1Field;

    private PartyType partyField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BuyerProfileURIType BuyerProfileURI
    {
        get => buyerProfileURIField;
        set => buyerProfileURIField = value;
    }

    /// <remarks />
    [XmlElement("ContractingPartyType")]
    public ContractingPartyTypeType[] ContractingPartyType1
    {
        get => contractingPartyType1Field;
        set => contractingPartyType1Field = value;
    }

    /// <remarks />
    [XmlElement("ContractingActivity")]
    public ContractingActivityType[] ContractingActivity
    {
        get => contractingActivityField;
        set => contractingActivityField = value;
    }

    /// <remarks />
    public PartyType Party
    {
        get => partyField;
        set => partyField = value;
    }
}