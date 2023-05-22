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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public class CertIDType
{
    private DigestAlgAndValueType certDigestField;

    private X509IssuerSerialType issuerSerialField;

    private string uRIField;

    /// <remarks />
    public DigestAlgAndValueType CertDigest
    {
        get => certDigestField;
        set => certDigestField = value;
    }

    /// <remarks />
    public X509IssuerSerialType IssuerSerial
    {
        get => issuerSerialField;
        set => issuerSerialField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get => uRIField;
        set => uRIField = value;
    }
}