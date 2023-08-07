using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("ApplicableTransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportMeansType
{
    private AirTransportType airTransportField;

    private DirectionCodeType directionCodeField;

    private JourneyIDType journeyIDField;

    private MaritimeTransportType maritimeTransportField;

    private DimensionType[] measurementDimensionField;

    private PartyType ownerPartyField;

    private RailTransportType railTransportField;

    private RegistrationNationalityType[] registrationNationalityField;

    private RegistrationNationalityIDType registrationNationalityIDField;

    private RoadTransportType roadTransportField;

    private StowageType stowageField;

    private TradeServiceCodeType tradeServiceCodeField;

    private TransportMeansTypeCodeType transportMeansTypeCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public JourneyIDType JourneyID
    {
        get => journeyIDField;
        set => journeyIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationNationalityIDType RegistrationNationalityID
    {
        get => registrationNationalityIDField;
        set => registrationNationalityIDField = value;
    }

    /// <remarks />
    [XmlElement("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationNationalityType[] RegistrationNationality
    {
        get => registrationNationalityField;
        set => registrationNationalityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DirectionCodeType DirectionCode
    {
        get => directionCodeField;
        set => directionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportMeansTypeCodeType TransportMeansTypeCode
    {
        get => transportMeansTypeCodeField;
        set => transportMeansTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TradeServiceCodeType TradeServiceCode
    {
        get => tradeServiceCodeField;
        set => tradeServiceCodeField = value;
    }

    /// <remarks />
    public StowageType Stowage
    {
        get => stowageField;
        set => stowageField = value;
    }

    /// <remarks />
    public AirTransportType AirTransport
    {
        get => airTransportField;
        set => airTransportField = value;
    }

    /// <remarks />
    public RoadTransportType RoadTransport
    {
        get => roadTransportField;
        set => roadTransportField = value;
    }

    /// <remarks />
    public RailTransportType RailTransport
    {
        get => railTransportField;
        set => railTransportField = value;
    }

    /// <remarks />
    public MaritimeTransportType MaritimeTransport
    {
        get => maritimeTransportField;
        set => maritimeTransportField = value;
    }

    /// <remarks />
    public PartyType OwnerParty
    {
        get => ownerPartyField;
        set => ownerPartyField = value;
    }

    /// <remarks />
    [XmlElement("MeasurementDimension")]
    public DimensionType[] MeasurementDimension
    {
        get => measurementDimensionField;
        set => measurementDimensionField = value;
    }
}