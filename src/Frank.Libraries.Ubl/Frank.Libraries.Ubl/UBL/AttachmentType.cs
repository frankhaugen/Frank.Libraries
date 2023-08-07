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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AttachmentType
{
    private EmbeddedDocumentBinaryObjectType embeddedDocumentBinaryObjectField;

    private ExternalReferenceType externalReferenceField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EmbeddedDocumentBinaryObjectType EmbeddedDocumentBinaryObject
    {
        get => embeddedDocumentBinaryObjectField;
        set => embeddedDocumentBinaryObjectField = value;
    }

    /// <remarks />
    public ExternalReferenceType ExternalReference
    {
        get => externalReferenceField;
        set => externalReferenceField = value;
    }
}