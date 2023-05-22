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
public class CRLIdentifierType
{
    private string issuerField;

    private DateTime issueTimeField;

    private string numberField;

    private string uRIField;

    /// <remarks />
    public string Issuer
    {
        get => issuerField;
        set => issuerField = value;
    }

    /// <remarks />
    public DateTime IssueTime
    {
        get => issueTimeField;
        set => issueTimeField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "integer")]
    public string Number
    {
        get => numberField;
        set => numberField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get => uRIField;
        set => uRIField = value;
    }
}