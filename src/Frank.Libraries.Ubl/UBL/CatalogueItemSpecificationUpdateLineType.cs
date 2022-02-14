namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueItemSpecificationUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class CatalogueItemSpecificationUpdateLineType
{

    private IDType idField;

    private CustomerPartyType contractorCustomerPartyField;

    private SupplierPartyType sellerSupplierPartyField;

    private ItemType itemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public CustomerPartyType ContractorCustomerParty
    {
        get
        {
            return this.contractorCustomerPartyField;
        }
        set
        {
            this.contractorCustomerPartyField = value;
        }
    }

    /// <remarks/>
    public SupplierPartyType SellerSupplierParty
    {
        get
        {
            return this.sellerSupplierPartyField;
        }
        set
        {
            this.sellerSupplierPartyField = value;
        }
    }

    /// <remarks/>
    public ItemType Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}