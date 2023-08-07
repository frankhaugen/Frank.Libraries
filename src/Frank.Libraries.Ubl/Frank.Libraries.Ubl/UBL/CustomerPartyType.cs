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
[XmlRoot("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CustomerPartyType
{
    private ContactType accountingContactField;

    private AdditionalAccountIDType[] additionalAccountIDField;

    private ContactType buyerContactField;

    private CustomerAssignedAccountIDType customerAssignedAccountIDField;

    private ContactType deliveryContactField;

    private PartyType partyField;

    private SupplierAssignedAccountIDType supplierAssignedAccountIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomerAssignedAccountIDType CustomerAssignedAccountID
    {
        get => customerAssignedAccountIDField;
        set => customerAssignedAccountIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SupplierAssignedAccountIDType SupplierAssignedAccountID
    {
        get => supplierAssignedAccountIDField;
        set => supplierAssignedAccountIDField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalAccountIDType[] AdditionalAccountID
    {
        get => additionalAccountIDField;
        set => additionalAccountIDField = value;
    }

    /// <remarks />
    public PartyType Party
    {
        get => partyField;
        set => partyField = value;
    }

    /// <remarks />
    public ContactType DeliveryContact
    {
        get => deliveryContactField;
        set => deliveryContactField = value;
    }

    /// <remarks />
    public ContactType AccountingContact
    {
        get => accountingContactField;
        set => accountingContactField = value;
    }

    /// <remarks />
    public ContactType BuyerContact
    {
        get => buyerContactField;
        set => buyerContactField = value;
    }
}