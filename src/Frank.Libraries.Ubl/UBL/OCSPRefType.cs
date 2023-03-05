using System;
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
public class OCSPRefType
{
    private DigestAlgAndValueType digestAlgAndValueField;

    private OCSPIdentifierType oCSPIdentifierField;

    /// <remarks />
    public OCSPIdentifierType OCSPIdentifier
    {
        get => oCSPIdentifierField;
        set => oCSPIdentifierField = value;
    }

    /// <remarks />
    public DigestAlgAndValueType DigestAlgAndValue
    {
        get => digestAlgAndValueField;
        set => digestAlgAndValueField = value;
    }
}