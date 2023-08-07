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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class CertIDListType
{
    private CertIDType[] certField;

    /// <remarks />
    [XmlElement("Cert")]
    public CertIDType[] Cert
    {
        get => certField;
        set => certField = value;
    }
}