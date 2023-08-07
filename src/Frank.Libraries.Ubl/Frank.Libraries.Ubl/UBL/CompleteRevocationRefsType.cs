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
[XmlRoot("CompleteRevocationRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class CompleteRevocationRefsType
{
    private CRLRefType[] cRLRefsField;

    private string idField;

    private OCSPRefType[] oCSPRefsField;

    private AnyType[] otherRefsField;

    /// <remarks />
    [XmlArrayItem("CRLRef", IsNullable = false)]
    public CRLRefType[] CRLRefs
    {
        get => cRLRefsField;
        set => cRLRefsField = value;
    }

    /// <remarks />
    [XmlArrayItem("OCSPRef", IsNullable = false)]
    public OCSPRefType[] OCSPRefs
    {
        get => oCSPRefsField;
        set => oCSPRefsField = value;
    }

    /// <remarks />
    [XmlArrayItem("OtherRef", IsNullable = false)]
    public AnyType[] OtherRefs
    {
        get => otherRefsField;
        set => otherRefsField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}