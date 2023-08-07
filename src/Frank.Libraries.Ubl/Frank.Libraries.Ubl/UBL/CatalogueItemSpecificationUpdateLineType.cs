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
[XmlRoot("CatalogueItemSpecificationUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CatalogueItemSpecificationUpdateLineType
{
    private CustomerPartyType contractorCustomerPartyField;

    private IDType idField;

    private ItemType itemField;

    private SupplierPartyType sellerSupplierPartyField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    public CustomerPartyType ContractorCustomerParty
    {
        get => contractorCustomerPartyField;
        set => contractorCustomerPartyField = value;
    }

    /// <remarks />
    public SupplierPartyType SellerSupplierParty
    {
        get => sellerSupplierPartyField;
        set => sellerSupplierPartyField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }
}