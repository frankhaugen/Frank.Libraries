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
[XmlRoot("AdditionalItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ItemIdentificationType
{
    private BarcodeSymbologyIDType barcodeSymbologyIDField;

    private ExtendedIDType extendedIDField;

    private IDType idField;

    private PartyType issuerPartyField;

    private DimensionType[] measurementDimensionField;

    private PhysicalAttributeType[] physicalAttributeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExtendedIDType ExtendedID
    {
        get => extendedIDField;
        set => extendedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BarcodeSymbologyIDType BarcodeSymbologyID
    {
        get => barcodeSymbologyIDField;
        set => barcodeSymbologyIDField = value;
    }

    /// <remarks />
    [XmlElement("PhysicalAttribute")]
    public PhysicalAttributeType[] PhysicalAttribute
    {
        get => physicalAttributeField;
        set => physicalAttributeField = value;
    }

    /// <remarks />
    [XmlElement("MeasurementDimension")]
    public DimensionType[] MeasurementDimension
    {
        get => measurementDimensionField;
        set => measurementDimensionField = value;
    }

    /// <remarks />
    public PartyType IssuerParty
    {
        get => issuerPartyField;
        set => issuerPartyField = value;
    }
}