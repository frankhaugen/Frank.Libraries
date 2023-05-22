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
[XmlRoot("SPUserNotice", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class SPUserNoticeType
{
    private string explicitTextField;

    private NoticeReferenceType noticeRefField;

    /// <remarks />
    public NoticeReferenceType NoticeRef
    {
        get => noticeRefField;
        set => noticeRefField = value;
    }

    /// <remarks />
    public string ExplicitText
    {
        get => explicitTextField;
        set => explicitTextField = value;
    }
}