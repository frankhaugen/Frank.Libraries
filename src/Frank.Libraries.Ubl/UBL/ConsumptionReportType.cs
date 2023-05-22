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
[XmlRoot("ConsumptionReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ConsumptionReportType
{
    private BasicConsumedQuantityType basicConsumedQuantityField;

    private ConsumersEnergyLevelCodeType consumersEnergyLevelCodeField;

    private ConsumersEnergyLevelType consumersEnergyLevelField;

    private ConsumptionHistoryType[] consumptionHistoryField;

    private ConsumptionReportReferenceType[] consumptionReportReferenceField;

    private ConsumptionTypeCodeType consumptionTypeCodeField;

    private ConsumptionTypeType consumptionTypeField;

    private DescriptionType[] descriptionField;

    private DocumentReferenceType documentReferenceField;

    private DocumentReferenceType guidanceDocumentReferenceField;

    private HeatingTypeCodeType heatingTypeCodeField;

    private HeatingTypeType heatingTypeField;

    private IDType idField;

    private PeriodType periodField;

    private ResidenceTypeCodeType residenceTypeCodeField;

    private ResidenceTypeType residenceTypeField;

    private ResidentOccupantsNumericType residentOccupantsNumericField;

    private TotalConsumedQuantityType totalConsumedQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeType ConsumptionType
    {
        get => consumptionTypeField;
        set => consumptionTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionTypeCodeType ConsumptionTypeCode
    {
        get => consumptionTypeCodeField;
        set => consumptionTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalConsumedQuantityType TotalConsumedQuantity
    {
        get => totalConsumedQuantityField;
        set => totalConsumedQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BasicConsumedQuantityType BasicConsumedQuantity
    {
        get => basicConsumedQuantityField;
        set => basicConsumedQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResidentOccupantsNumericType ResidentOccupantsNumeric
    {
        get => residentOccupantsNumericField;
        set => residentOccupantsNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumersEnergyLevelCodeType ConsumersEnergyLevelCode
    {
        get => consumersEnergyLevelCodeField;
        set => consumersEnergyLevelCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumersEnergyLevelType ConsumersEnergyLevel
    {
        get => consumersEnergyLevelField;
        set => consumersEnergyLevelField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResidenceTypeType ResidenceType
    {
        get => residenceTypeField;
        set => residenceTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResidenceTypeCodeType ResidenceTypeCode
    {
        get => residenceTypeCodeField;
        set => residenceTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HeatingTypeType HeatingType
    {
        get => heatingTypeField;
        set => heatingTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HeatingTypeCodeType HeatingTypeCode
    {
        get => heatingTypeCodeField;
        set => heatingTypeCodeField = value;
    }

    /// <remarks />
    public PeriodType Period
    {
        get => periodField;
        set => periodField = value;
    }

    /// <remarks />
    public DocumentReferenceType GuidanceDocumentReference
    {
        get => guidanceDocumentReferenceField;
        set => guidanceDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ConsumptionReportReference")]
    public ConsumptionReportReferenceType[] ConsumptionReportReference
    {
        get => consumptionReportReferenceField;
        set => consumptionReportReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ConsumptionHistory")]
    public ConsumptionHistoryType[] ConsumptionHistory
    {
        get => consumptionHistoryField;
        set => consumptionHistoryField = value;
    }
}