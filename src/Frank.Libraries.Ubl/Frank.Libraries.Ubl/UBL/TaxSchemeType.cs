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
[XmlRoot("TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TaxSchemeType
{
    private CurrencyCodeType currencyCodeField;

    private IDType idField;

    private AddressType[] jurisdictionRegionAddressField;

    private NameType1 nameField;

    private TaxTypeCodeType taxTypeCodeField;

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
    public TaxTypeCodeType TaxTypeCode
    {
        get => taxTypeCodeField;
        set => taxTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CurrencyCodeType CurrencyCode
    {
        get => currencyCodeField;
        set => currencyCodeField = value;
    }

    /// <remarks />
    [XmlElement("JurisdictionRegionAddress")]
    public AddressType[] JurisdictionRegionAddress
    {
        get => jurisdictionRegionAddressField;
        set => jurisdictionRegionAddressField = value;
    }
}