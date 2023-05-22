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
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public class X509IssuerSerialType
{
    private string x509IssuerNameField;

    private string x509SerialNumberField;

    /// <remarks />
    public string X509IssuerName
    {
        get => x509IssuerNameField;
        set => x509IssuerNameField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "integer")]
    public string X509SerialNumber
    {
        get => x509SerialNumberField;
        set => x509SerialNumberField = value;
    }
}