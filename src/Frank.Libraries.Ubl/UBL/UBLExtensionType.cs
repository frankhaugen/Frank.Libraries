using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
[XmlRoot("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
public class UBLExtensionType
{
    private ExtensionAgencyIDType extensionAgencyIDField;

    private ExtensionAgencyNameType extensionAgencyNameField;

    private ExtensionAgencyURIType extensionAgencyURIField;

    private XmlElement extensionContentField;

    private ExtensionReasonCodeType extensionReasonCodeField;

    private ExtensionReasonType extensionReasonField;

    private ExtensionURIType extensionURIField;

    private ExtensionVersionIDType extensionVersionIDField;

    private IDType idField;

    private NameType1 nameField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    public ExtensionAgencyIDType ExtensionAgencyID
    {
        get => extensionAgencyIDField;
        set => extensionAgencyIDField = value;
    }

    /// <remarks />
    public ExtensionAgencyNameType ExtensionAgencyName
    {
        get => extensionAgencyNameField;
        set => extensionAgencyNameField = value;
    }

    /// <remarks />
    public ExtensionVersionIDType ExtensionVersionID
    {
        get => extensionVersionIDField;
        set => extensionVersionIDField = value;
    }

    /// <remarks />
    public ExtensionAgencyURIType ExtensionAgencyURI
    {
        get => extensionAgencyURIField;
        set => extensionAgencyURIField = value;
    }

    /// <remarks />
    public ExtensionURIType ExtensionURI
    {
        get => extensionURIField;
        set => extensionURIField = value;
    }

    /// <remarks />
    public ExtensionReasonCodeType ExtensionReasonCode
    {
        get => extensionReasonCodeField;
        set => extensionReasonCodeField = value;
    }

    /// <remarks />
    public ExtensionReasonType ExtensionReason
    {
        get => extensionReasonField;
        set => extensionReasonField = value;
    }

    /// <remarks />
    public XmlElement ExtensionContent
    {
        get => extensionContentField;
        set => extensionContentField = value;
    }
}