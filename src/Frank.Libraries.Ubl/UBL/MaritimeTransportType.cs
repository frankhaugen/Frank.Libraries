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
[XmlRoot("MaritimeTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class MaritimeTransportType
{
    private GrossTonnageMeasureType grossTonnageMeasureField;

    private NetTonnageMeasureType netTonnageMeasureField;

    private RadioCallSignIDType radioCallSignIDField;

    private DocumentReferenceType registryCertificateDocumentReferenceField;

    private LocationType1 registryPortLocationField;

    private ShipsRequirementsType[] shipsRequirementsField;

    private VesselIDType vesselIDField;

    private VesselNameType vesselNameField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VesselIDType VesselID
    {
        get => vesselIDField;
        set => vesselIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VesselNameType VesselName
    {
        get => vesselNameField;
        set => vesselNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RadioCallSignIDType RadioCallSignID
    {
        get => radioCallSignIDField;
        set => radioCallSignIDField = value;
    }

    /// <remarks />
    [XmlElement("ShipsRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShipsRequirementsType[] ShipsRequirements
    {
        get => shipsRequirementsField;
        set => shipsRequirementsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossTonnageMeasureType GrossTonnageMeasure
    {
        get => grossTonnageMeasureField;
        set => grossTonnageMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetTonnageMeasureType NetTonnageMeasure
    {
        get => netTonnageMeasureField;
        set => netTonnageMeasureField = value;
    }

    /// <remarks />
    public DocumentReferenceType RegistryCertificateDocumentReference
    {
        get => registryCertificateDocumentReferenceField;
        set => registryCertificateDocumentReferenceField = value;
    }

    /// <remarks />
    public LocationType1 RegistryPortLocation
    {
        get => registryPortLocationField;
        set => registryPortLocationField = value;
    }
}