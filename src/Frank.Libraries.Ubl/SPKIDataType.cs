namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public partial class SPKIDataType
{

    private byte[][] sPKISexpField;

    private System.Xml.XmlElement anyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType = "base64Binary")]
    public byte[][] SPKISexp
    {
        get
        {
            return this.sPKISexpField;
        }
        set
        {
            this.sPKISexpField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}