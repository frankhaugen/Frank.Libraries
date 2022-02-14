namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("InventoryReportLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class InventoryReportLineType
{

    private IDType idField;

    private NoteType[] noteField;

    private QuantityType2 quantityField;

    private InventoryValueAmountType inventoryValueAmountField;

    private AvailabilityDateType availabilityDateField;

    private AvailabilityStatusCodeType availabilityStatusCodeField;

    private ItemType itemField;

    private LocationType1 inventoryLocationField;

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
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InventoryValueAmountType InventoryValueAmount
    {
        get
        {
            return this.inventoryValueAmountField;
        }
        set
        {
            this.inventoryValueAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AvailabilityDateType AvailabilityDate
    {
        get
        {
            return this.availabilityDateField;
        }
        set
        {
            this.availabilityDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AvailabilityStatusCodeType AvailabilityStatusCode
    {
        get
        {
            return this.availabilityStatusCodeField;
        }
        set
        {
            this.availabilityStatusCodeField = value;
        }
    }

    /// <remarks/>
    public ItemType Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }

    /// <remarks/>
    public LocationType1 InventoryLocation
    {
        get
        {
            return this.inventoryLocationField;
        }
        set
        {
            this.inventoryLocationField = value;
        }
    }
}