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
[XmlRoot("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class SupplierPartyType
{
    private ContactType accountingContactField;

    private AdditionalAccountIDType[] additionalAccountIDField;

    private CustomerAssignedAccountIDType customerAssignedAccountIDField;

    private DataSendingCapabilityType dataSendingCapabilityField;

    private ContactType despatchContactField;

    private PartyType partyField;

    private ContactType sellerContactField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomerAssignedAccountIDType CustomerAssignedAccountID
    {
        get => customerAssignedAccountIDField;
        set => customerAssignedAccountIDField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalAccountIDType[] AdditionalAccountID
    {
        get => additionalAccountIDField;
        set => additionalAccountIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DataSendingCapabilityType DataSendingCapability
    {
        get => dataSendingCapabilityField;
        set => dataSendingCapabilityField = value;
    }

    /// <remarks />
    public PartyType Party
    {
        get => partyField;
        set => partyField = value;
    }

    /// <remarks />
    public ContactType DespatchContact
    {
        get => despatchContactField;
        set => despatchContactField = value;
    }

    /// <remarks />
    public ContactType AccountingContact
    {
        get => accountingContactField;
        set => accountingContactField = value;
    }

    /// <remarks />
    public ContactType SellerContact
    {
        get => sellerContactField;
        set => sellerContactField = value;
    }
}