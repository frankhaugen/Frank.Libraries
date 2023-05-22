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
[XmlRoot("CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CorporateRegistrationSchemeType
{
    private CorporateRegistrationTypeCodeType corporateRegistrationTypeCodeField;

    private IDType idField;

    private AddressType[] jurisdictionRegionAddressField;

    private NameType1 nameField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CorporateRegistrationTypeCodeType CorporateRegistrationTypeCode
    {
        get => corporateRegistrationTypeCodeField;
        set => corporateRegistrationTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("JurisdictionRegionAddress")]
    public AddressType[] JurisdictionRegionAddress
    {
        get => jurisdictionRegionAddressField;
        set => jurisdictionRegionAddressField = value;
    }
}