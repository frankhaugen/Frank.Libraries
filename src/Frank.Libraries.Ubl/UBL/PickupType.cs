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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PickupType
{
    private ActualPickupDateType actualPickupDateField;

    private ActualPickupTimeType actualPickupTimeField;

    private EarliestPickupDateType earliestPickupDateField;

    private EarliestPickupTimeType earliestPickupTimeField;

    private IDType idField;

    private LatestPickupDateType latestPickupDateField;

    private LatestPickupTimeType latestPickupTimeField;

    private LocationType1 pickupLocationField;

    private PartyType pickupPartyField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualPickupDateType ActualPickupDate
    {
        get => actualPickupDateField;
        set => actualPickupDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualPickupTimeType ActualPickupTime
    {
        get => actualPickupTimeField;
        set => actualPickupTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EarliestPickupDateType EarliestPickupDate
    {
        get => earliestPickupDateField;
        set => earliestPickupDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EarliestPickupTimeType EarliestPickupTime
    {
        get => earliestPickupTimeField;
        set => earliestPickupTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestPickupDateType LatestPickupDate
    {
        get => latestPickupDateField;
        set => latestPickupDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestPickupTimeType LatestPickupTime
    {
        get => latestPickupTimeField;
        set => latestPickupTimeField = value;
    }

    /// <remarks />
    public LocationType1 PickupLocation
    {
        get => pickupLocationField;
        set => pickupLocationField = value;
    }

    /// <remarks />
    public PartyType PickupParty
    {
        get => pickupPartyField;
        set => pickupPartyField = value;
    }
}