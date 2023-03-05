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
[XmlRoot("ObjectIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class ObjectIdentifierType
{
    private string descriptionField;

    private DocumentationReferencesType documentationReferencesField;

    private IdentifierType2 identifierField;

    /// <remarks />
    public IdentifierType2 Identifier
    {
        get => identifierField;
        set => identifierField = value;
    }

    /// <remarks />
    public string Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    public DocumentationReferencesType DocumentationReferences
    {
        get => documentationReferencesField;
        set => documentationReferencesField = value;
    }
}