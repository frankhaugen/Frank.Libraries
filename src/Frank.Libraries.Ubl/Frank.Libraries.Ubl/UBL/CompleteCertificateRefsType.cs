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
[XmlRoot("CompleteCertificateRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class CompleteCertificateRefsType
{
    private CertIDType[] certRefsField;

    private string idField;

    /// <remarks />
    [XmlArrayItem("Cert", IsNullable = false)]
    public CertIDType[] CertRefs
    {
        get => certRefsField;
        set => certRefsField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}