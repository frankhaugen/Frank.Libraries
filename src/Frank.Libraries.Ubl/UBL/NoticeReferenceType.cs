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
public class NoticeReferenceType
{
    private string[] noticeNumbersField;

    private string organizationField;

    /// <remarks />
    public string Organization
    {
        get => organizationField;
        set => organizationField = value;
    }

    /// <remarks />
    [XmlArrayItem("int", DataType = "integer", IsNullable = false)]
    public string[] NoticeNumbers
    {
        get => noticeNumbersField;
        set => noticeNumbersField = value;
    }
}