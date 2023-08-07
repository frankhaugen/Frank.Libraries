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
[XmlRoot("CounterSignature", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class CounterSignatureType
{
    private SignatureType1 signatureField;

    /// <remarks />
    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public SignatureType1 Signature
    {
        get => signatureField;
        set => signatureField = value;
    }
}