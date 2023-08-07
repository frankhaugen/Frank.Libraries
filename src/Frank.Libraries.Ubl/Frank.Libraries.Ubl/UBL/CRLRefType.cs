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
public class CRLRefType
{
    private CRLIdentifierType cRLIdentifierField;

    private DigestAlgAndValueType digestAlgAndValueField;

    /// <remarks />
    public DigestAlgAndValueType DigestAlgAndValue
    {
        get => digestAlgAndValueField;
        set => digestAlgAndValueField = value;
    }

    /// <remarks />
    public CRLIdentifierType CRLIdentifier
    {
        get => cRLIdentifierField;
        set => cRLIdentifierField = value;
    }
}