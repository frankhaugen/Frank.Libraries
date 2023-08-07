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
[XmlRoot("SignaturePolicyIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class SignaturePolicyIdentifierType
{
    private object itemField;

    /// <remarks />
    [XmlElement("SignaturePolicyId", typeof(SignaturePolicyIdType))]
    [XmlElement("SignaturePolicyImplied", typeof(object))]
    public object Item
    {
        get => itemField;
        set => itemField = value;
    }
}