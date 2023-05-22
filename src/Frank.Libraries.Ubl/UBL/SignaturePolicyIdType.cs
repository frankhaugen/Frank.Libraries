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
public class SignaturePolicyIdType
{
    private DigestAlgAndValueType sigPolicyHashField;

    private ObjectIdentifierType sigPolicyIdField;

    private AnyType[] sigPolicyQualifiersField;

    private TransformType[] transformsField;

    /// <remarks />
    public ObjectIdentifierType SigPolicyId
    {
        get => sigPolicyIdField;
        set => sigPolicyIdField = value;
    }

    /// <remarks />
    [XmlArray(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlArrayItem("Transform", IsNullable = false)]
    public TransformType[] Transforms
    {
        get => transformsField;
        set => transformsField = value;
    }

    /// <remarks />
    public DigestAlgAndValueType SigPolicyHash
    {
        get => sigPolicyHashField;
        set => sigPolicyHashField = value;
    }

    /// <remarks />
    [XmlArrayItem("SigPolicyQualifier", IsNullable = false)]
    public AnyType[] SigPolicyQualifiers
    {
        get => sigPolicyQualifiersField;
        set => sigPolicyQualifiersField = value;
    }
}