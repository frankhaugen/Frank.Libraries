namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PickupType
{

    private IDType idField;

    private ActualPickupDateType actualPickupDateField;

    private ActualPickupTimeType actualPickupTimeField;

    private EarliestPickupDateType earliestPickupDateField;

    private EarliestPickupTimeType earliestPickupTimeField;

    private LatestPickupDateType latestPickupDateField;

    private LatestPickupTimeType latestPickupTimeField;

    private LocationType1 pickupLocationField;

    private PartyType pickupPartyField;

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
    public ActualPickupDateType ActualPickupDate
    {
        get
        {
            return this.actualPickupDateField;
        }
        set
        {
            this.actualPickupDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualPickupTimeType ActualPickupTime
    {
        get
        {
            return this.actualPickupTimeField;
        }
        set
        {
            this.actualPickupTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EarliestPickupDateType EarliestPickupDate
    {
        get
        {
            return this.earliestPickupDateField;
        }
        set
        {
            this.earliestPickupDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EarliestPickupTimeType EarliestPickupTime
    {
        get
        {
            return this.earliestPickupTimeField;
        }
        set
        {
            this.earliestPickupTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestPickupDateType LatestPickupDate
    {
        get
        {
            return this.latestPickupDateField;
        }
        set
        {
            this.latestPickupDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestPickupTimeType LatestPickupTime
    {
        get
        {
            return this.latestPickupTimeField;
        }
        set
        {
            this.latestPickupTimeField = value;
        }
    }

    /// <remarks/>
    public LocationType1 PickupLocation
    {
        get
        {
            return this.pickupLocationField;
        }
        set
        {
            this.pickupLocationField = value;
        }
    }

    /// <remarks/>
    public PartyType PickupParty
    {
        get
        {
            return this.pickupPartyField;
        }
        set
        {
            this.pickupPartyField = value;
        }
    }
}