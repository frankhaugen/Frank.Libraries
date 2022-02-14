namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
public partial class UBLExtensionType
{

    private IDType idField;

    private NameType1 nameField;

    private ExtensionAgencyIDType extensionAgencyIDField;

    private ExtensionAgencyNameType extensionAgencyNameField;

    private ExtensionVersionIDType extensionVersionIDField;

    private ExtensionAgencyURIType extensionAgencyURIField;

    private ExtensionURIType extensionURIField;

    private ExtensionReasonCodeType extensionReasonCodeField;

    private ExtensionReasonType extensionReasonField;

    private System.Xml.XmlElement extensionContentField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public ExtensionAgencyIDType ExtensionAgencyID
    {
        get
        {
            return this.extensionAgencyIDField;
        }
        set
        {
            this.extensionAgencyIDField = value;
        }
    }

    /// <remarks/>
    public ExtensionAgencyNameType ExtensionAgencyName
    {
        get
        {
            return this.extensionAgencyNameField;
        }
        set
        {
            this.extensionAgencyNameField = value;
        }
    }

    /// <remarks/>
    public ExtensionVersionIDType ExtensionVersionID
    {
        get
        {
            return this.extensionVersionIDField;
        }
        set
        {
            this.extensionVersionIDField = value;
        }
    }

    /// <remarks/>
    public ExtensionAgencyURIType ExtensionAgencyURI
    {
        get
        {
            return this.extensionAgencyURIField;
        }
        set
        {
            this.extensionAgencyURIField = value;
        }
    }

    /// <remarks/>
    public ExtensionURIType ExtensionURI
    {
        get
        {
            return this.extensionURIField;
        }
        set
        {
            this.extensionURIField = value;
        }
    }

    /// <remarks/>
    public ExtensionReasonCodeType ExtensionReasonCode
    {
        get
        {
            return this.extensionReasonCodeField;
        }
        set
        {
            this.extensionReasonCodeField = value;
        }
    }

    /// <remarks/>
    public ExtensionReasonType ExtensionReason
    {
        get
        {
            return this.extensionReasonField;
        }
        set
        {
            this.extensionReasonField = value;
        }
    }

    /// <remarks/>
    public System.Xml.XmlElement ExtensionContent
    {
        get
        {
            return this.extensionContentField;
        }
        set
        {
            this.extensionContentField = value;
        }
    }
}