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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("LineResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class LineResponseType
{
    private LineReferenceType lineReferenceField;

    private ResponseType[] responseField;

    /// <remarks />
    public LineReferenceType LineReference
    {
        get => lineReferenceField;
        set => lineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Response")]
    public ResponseType[] Response
    {
        get => responseField;
        set => responseField = value;
    }
}