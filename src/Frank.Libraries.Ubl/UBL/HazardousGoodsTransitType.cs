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
[XmlRoot("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class HazardousGoodsTransitType
{
    private HazardousRegulationCodeType hazardousRegulationCodeField;

    private InhalationToxicityZoneCodeType inhalationToxicityZoneCodeField;

    private TemperatureType maximumTemperatureField;

    private TemperatureType minimumTemperatureField;

    private PackingCriteriaCodeType packingCriteriaCodeField;

    private TransportAuthorizationCodeType transportAuthorizationCodeField;

    private TransportEmergencyCardCodeType transportEmergencyCardCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportEmergencyCardCodeType TransportEmergencyCardCode
    {
        get => transportEmergencyCardCodeField;
        set => transportEmergencyCardCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackingCriteriaCodeType PackingCriteriaCode
    {
        get => packingCriteriaCodeField;
        set => packingCriteriaCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRegulationCodeType HazardousRegulationCode
    {
        get => hazardousRegulationCodeField;
        set => hazardousRegulationCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InhalationToxicityZoneCodeType InhalationToxicityZoneCode
    {
        get => inhalationToxicityZoneCodeField;
        set => inhalationToxicityZoneCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportAuthorizationCodeType TransportAuthorizationCode
    {
        get => transportAuthorizationCodeField;
        set => transportAuthorizationCodeField = value;
    }

    /// <remarks />
    public TemperatureType MaximumTemperature
    {
        get => maximumTemperatureField;
        set => maximumTemperatureField = value;
    }

    /// <remarks />
    public TemperatureType MinimumTemperature
    {
        get => minimumTemperatureField;
        set => minimumTemperatureField = value;
    }
}