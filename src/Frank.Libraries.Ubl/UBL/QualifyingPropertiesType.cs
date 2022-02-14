namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class QualifyingPropertiesType
{

    private SignedPropertiesType signedPropertiesField;

    private UnsignedPropertiesType unsignedPropertiesField;

    private string targetField;

    private string idField;

    /// <remarks/>
    public SignedPropertiesType SignedProperties
    {
        get
        {
            return this.signedPropertiesField;
        }
        set
        {
            this.signedPropertiesField = value;
        }
    }

    /// <remarks/>
    public UnsignedPropertiesType UnsignedProperties
    {
        get
        {
            return this.unsignedPropertiesField;
        }
        set
        {
            this.unsignedPropertiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Target
    {
        get
        {
            return this.targetField;
        }
        set
        {
            this.targetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
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
}