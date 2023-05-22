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
[XmlRoot("ServiceProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ServiceProviderPartyType
{
    private IDType idField;

    private PartyType partyField;

    private ContactType sellerContactField;

    private ServiceTypeCodeType serviceTypeCodeField;

    private ServiceTypeType[] serviceTypeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ServiceTypeCodeType ServiceTypeCode
    {
        get => serviceTypeCodeField;
        set => serviceTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("ServiceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ServiceTypeType[] ServiceType
    {
        get => serviceTypeField;
        set => serviceTypeField = value;
    }

    /// <remarks />
    public PartyType Party
    {
        get => partyField;
        set => partyField = value;
    }

    /// <remarks />
    public ContactType SellerContact
    {
        get => sellerContactField;
        set => sellerContactField = value;
    }
}