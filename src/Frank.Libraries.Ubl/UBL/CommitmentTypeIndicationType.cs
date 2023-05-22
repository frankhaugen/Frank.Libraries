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
[XmlRoot("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class CommitmentTypeIndicationType
{
    private ObjectIdentifierType commitmentTypeIdField;

    private AnyType[] commitmentTypeQualifiersField;

    private object[] itemsField;

    /// <remarks />
    public ObjectIdentifierType CommitmentTypeId
    {
        get => commitmentTypeIdField;
        set => commitmentTypeIdField = value;
    }

    /// <remarks />
    [XmlElement("AllSignedDataObjects", typeof(object))]
    [XmlElement("ObjectReference", typeof(string), DataType = "anyURI")]
    public object[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlArrayItem("CommitmentTypeQualifier", IsNullable = false)]
    public AnyType[] CommitmentTypeQualifiers
    {
        get => commitmentTypeQualifiersField;
        set => commitmentTypeQualifiersField = value;
    }
}