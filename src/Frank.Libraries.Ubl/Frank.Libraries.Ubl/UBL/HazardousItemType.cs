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
[XmlRoot("HazardousItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class HazardousItemType
{
    private AdditionalInformationType[] additionalInformationField;

    private TemperatureType[] additionalTemperatureField;

    private CategoryNameType categoryNameField;

    private PartyType contactPartyField;

    private EmergencyProceduresCodeType emergencyProceduresCodeField;

    private TemperatureType emergencyTemperatureField;

    private TemperatureType flashpointTemperatureField;

    private HazardClassIDType hazardClassIDField;

    private HazardousCategoryCodeType hazardousCategoryCodeField;

    private HazardousGoodsTransitType[] hazardousGoodsTransitField;

    private IDType idField;

    private LowerOrangeHazardPlacardIDType lowerOrangeHazardPlacardIDField;

    private MarkingIDType markingIDField;

    private MedicalFirstAidGuideCodeType medicalFirstAidGuideCodeField;

    private NetVolumeMeasureType netVolumeMeasureField;

    private NetWeightMeasureType netWeightMeasureField;

    private PlacardEndorsementType placardEndorsementField;

    private PlacardNotationType placardNotationField;

    private QuantityType2 quantityField;

    private SecondaryHazardType[] secondaryHazardField;

    private TechnicalNameType technicalNameField;

    private UNDGCodeType uNDGCodeField;

    private UpperOrangeHazardPlacardIDType upperOrangeHazardPlacardIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PlacardNotationType PlacardNotation
    {
        get => placardNotationField;
        set => placardNotationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PlacardEndorsementType PlacardEndorsement
    {
        get => placardEndorsementField;
        set => placardEndorsementField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalInformationType[] AdditionalInformation
    {
        get => additionalInformationField;
        set => additionalInformationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UNDGCodeType UNDGCode
    {
        get => uNDGCodeField;
        set => uNDGCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EmergencyProceduresCodeType EmergencyProceduresCode
    {
        get => emergencyProceduresCodeField;
        set => emergencyProceduresCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MedicalFirstAidGuideCodeType MedicalFirstAidGuideCode
    {
        get => medicalFirstAidGuideCodeField;
        set => medicalFirstAidGuideCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TechnicalNameType TechnicalName
    {
        get => technicalNameField;
        set => technicalNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CategoryNameType CategoryName
    {
        get => categoryNameField;
        set => categoryNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousCategoryCodeType HazardousCategoryCode
    {
        get => hazardousCategoryCodeField;
        set => hazardousCategoryCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UpperOrangeHazardPlacardIDType UpperOrangeHazardPlacardID
    {
        get => upperOrangeHazardPlacardIDField;
        set => upperOrangeHazardPlacardIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LowerOrangeHazardPlacardIDType LowerOrangeHazardPlacardID
    {
        get => lowerOrangeHazardPlacardIDField;
        set => lowerOrangeHazardPlacardIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarkingIDType MarkingID
    {
        get => markingIDField;
        set => markingIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardClassIDType HazardClassID
    {
        get => hazardClassIDField;
        set => hazardClassIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetWeightMeasureType NetWeightMeasure
    {
        get => netWeightMeasureField;
        set => netWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetVolumeMeasureType NetVolumeMeasure
    {
        get => netVolumeMeasureField;
        set => netVolumeMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    public PartyType ContactParty
    {
        get => contactPartyField;
        set => contactPartyField = value;
    }

    /// <remarks />
    [XmlElement("SecondaryHazard")]
    public SecondaryHazardType[] SecondaryHazard
    {
        get => secondaryHazardField;
        set => secondaryHazardField = value;
    }

    /// <remarks />
    [XmlElement("HazardousGoodsTransit")]
    public HazardousGoodsTransitType[] HazardousGoodsTransit
    {
        get => hazardousGoodsTransitField;
        set => hazardousGoodsTransitField = value;
    }

    /// <remarks />
    public TemperatureType EmergencyTemperature
    {
        get => emergencyTemperatureField;
        set => emergencyTemperatureField = value;
    }

    /// <remarks />
    public TemperatureType FlashpointTemperature
    {
        get => flashpointTemperatureField;
        set => flashpointTemperatureField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalTemperature")]
    public TemperatureType[] AdditionalTemperature
    {
        get => additionalTemperatureField;
        set => additionalTemperatureField = value;
    }
}