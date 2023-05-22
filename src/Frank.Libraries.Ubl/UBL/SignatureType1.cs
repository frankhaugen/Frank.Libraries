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
[XmlType(TypeName = "SignatureType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignatureType1
{
    private string idField;

    private KeyInfoType keyInfoField;

    private ObjectType[] objectField;

    private SignatureValueType signatureValueField;

    private SignedInfoType signedInfoField;

    /// <remarks />
    public SignedInfoType SignedInfo
    {
        get => signedInfoField;
        set => signedInfoField = value;
    }

    /// <remarks />
    public SignatureValueType SignatureValue
    {
        get => signatureValueField;
        set => signatureValueField = value;
    }

    /// <remarks />
    public KeyInfoType KeyInfo
    {
        get => keyInfoField;
        set => keyInfoField = value;
    }

    /// <remarks />
    [XmlElement("Object")]
    public ObjectType[] Object
    {
        get => objectField;
        set => objectField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}