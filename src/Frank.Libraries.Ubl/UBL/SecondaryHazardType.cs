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
[XmlRoot("SecondaryHazard", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class SecondaryHazardType
{
    private EmergencyProceduresCodeType emergencyProceduresCodeField;

    private ExtensionType[] extensionField;

    private IDType idField;

    private PlacardEndorsementType placardEndorsementField;

    private PlacardNotationType placardNotationField;

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
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EmergencyProceduresCodeType EmergencyProceduresCode
    {
        get => emergencyProceduresCodeField;
        set => emergencyProceduresCodeField = value;
    }

    /// <remarks />
    [XmlElement("Extension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExtensionType[] Extension
    {
        get => extensionField;
        set => extensionField = value;
    }
}