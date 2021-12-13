namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class OrderLineReferenceType
{

    private LineIDType lineIDField;

    private SalesOrderLineIDType salesOrderLineIDField;

    private UUIDType uUIDField;

    private LineStatusCodeType lineStatusCodeField;

    private OrderReferenceType orderReferenceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineIDType LineID
    {
        get
        {
            return this.lineIDField;
        }
        set
        {
            this.lineIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SalesOrderLineIDType SalesOrderLineID
    {
        get
        {
            return this.salesOrderLineIDField;
        }
        set
        {
            this.salesOrderLineIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get
        {
            return this.uUIDField;
        }
        set
        {
            this.uUIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineStatusCodeType LineStatusCode
    {
        get
        {
            return this.lineStatusCodeField;
        }
        set
        {
            this.lineStatusCodeField = value;
        }
    }

    /// <remarks/>
    public OrderReferenceType OrderReference
    {
        get
        {
            return this.orderReferenceField;
        }
        set
        {
            this.orderReferenceField = value;
        }
    }
}