namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TelecommunicationsSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TelecommunicationsSupplyType
{

    private TelecommunicationsSupplyTypeType telecommunicationsSupplyType1Field;

    private TelecommunicationsSupplyTypeCodeType telecommunicationsSupplyTypeCodeField;

    private PrivacyCodeType privacyCodeField;

    private DescriptionType[] descriptionField;

    private TotalAmountType totalAmountField;

    private TelecommunicationsSupplyLineType[] telecommunicationsSupplyLineField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsSupplyTypeType TelecommunicationsSupplyType1
    {
        get
        {
            return this.telecommunicationsSupplyType1Field;
        }
        set
        {
            this.telecommunicationsSupplyType1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsSupplyTypeCodeType TelecommunicationsSupplyTypeCode
    {
        get
        {
            return this.telecommunicationsSupplyTypeCodeField;
        }
        set
        {
            this.telecommunicationsSupplyTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrivacyCodeType PrivacyCode
    {
        get
        {
            return this.privacyCodeField;
        }
        set
        {
            this.privacyCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalAmountType TotalAmount
    {
        get
        {
            return this.totalAmountField;
        }
        set
        {
            this.totalAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyLine")]
    public TelecommunicationsSupplyLineType[] TelecommunicationsSupplyLine
    {
        get
        {
            return this.telecommunicationsSupplyLineField;
        }
        set
        {
            this.telecommunicationsSupplyLineField = value;
        }
    }
}