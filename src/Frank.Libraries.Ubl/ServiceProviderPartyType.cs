namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ServiceProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ServiceProviderPartyType
{

    private IDType idField;

    private ServiceTypeCodeType serviceTypeCodeField;

    private ServiceTypeType[] serviceTypeField;

    private PartyType partyField;

    private ContactType sellerContactField;

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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ServiceTypeCodeType ServiceTypeCode
    {
        get
        {
            return this.serviceTypeCodeField;
        }
        set
        {
            this.serviceTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ServiceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ServiceTypeType[] ServiceType
    {
        get
        {
            return this.serviceTypeField;
        }
        set
        {
            this.serviceTypeField = value;
        }
    }

    /// <remarks/>
    public PartyType Party
    {
        get
        {
            return this.partyField;
        }
        set
        {
            this.partyField = value;
        }
    }

    /// <remarks/>
    public ContactType SellerContact
    {
        get
        {
            return this.sellerContactField;
        }
        set
        {
            this.sellerContactField = value;
        }
    }
}