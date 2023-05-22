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
[XmlRoot("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignedInfoType
{
    private CanonicalizationMethodType1 canonicalizationMethodField;

    private string idField;

    private ReferenceType1[] referenceField;

    private SignatureMethodType1 signatureMethodField;

    /// <remarks />
    public CanonicalizationMethodType1 CanonicalizationMethod
    {
        get => canonicalizationMethodField;
        set => canonicalizationMethodField = value;
    }

    /// <remarks />
    public SignatureMethodType1 SignatureMethod
    {
        get => signatureMethodField;
        set => signatureMethodField = value;
    }

    /// <remarks />
    [XmlElement("Reference")]
    public ReferenceType1[] Reference
    {
        get => referenceField;
        set => referenceField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}