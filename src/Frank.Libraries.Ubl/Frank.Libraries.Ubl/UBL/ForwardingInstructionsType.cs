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
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForwardingInstructions-2")]
[XmlRoot("ForwardingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForwardingInstructions-2", IsNullable = false)]
public class ForwardingInstructionsType
{
    private AdValoremIndicatorType adValoremIndicatorField;

    private CarrierAssignedIDType carrierAssignedIDField;

    private PartyType carrierPartyField;

    private PartyType consignorPartyField;

    private CustomizationIDType customizationIDField;

    private DeclaredCarriageValueAmountType declaredCarriageValueAmountField;

    private DescriptionType[] descriptionField;

    private DocumentReferenceType[] documentReferenceField;

    private DocumentStatusCodeType documentStatusCodeField;

    private ExchangeRateType[] exchangeRateField;

    private PartyType freightForwarderPartyField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private NameType1 nameField;

    private NoteType[] noteField;

    private OtherInstructionType[] otherInstructionField;

    private ProfileExecutionIDType profileExecutionIDField;

    private ProfileIDType profileIDField;

    private ShipmentType shipmentField;

    private ShippingOrderIDType shippingOrderIDField;

    private SignatureType[] signatureField;

    private ToOrderIndicatorType toOrderIndicatorField;

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlArrayItem("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get => uBLExtensionsField;
        set => uBLExtensionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get => uBLVersionIDField;
        set => uBLVersionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get => customizationIDField;
        set => customizationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get => profileIDField;
        set => profileIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get => profileExecutionIDField;
        set => profileExecutionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierAssignedIDType CarrierAssignedID
    {
        get => carrierAssignedIDField;
        set => carrierAssignedIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get => issueDateField;
        set => issueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get => issueTimeField;
        set => issueTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusCodeType DocumentStatusCode
    {
        get => documentStatusCodeField;
        set => documentStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingOrderIDType ShippingOrderID
    {
        get => shippingOrderIDField;
        set => shippingOrderIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ToOrderIndicatorType ToOrderIndicator
    {
        get => toOrderIndicatorField;
        set => toOrderIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdValoremIndicatorType AdValoremIndicator
    {
        get => adValoremIndicatorField;
        set => adValoremIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredCarriageValueAmountType DeclaredCarriageValueAmount
    {
        get => declaredCarriageValueAmountField;
        set => declaredCarriageValueAmountField = value;
    }

    /// <remarks />
    [XmlElement("OtherInstruction", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OtherInstructionType[] OtherInstruction
    {
        get => otherInstructionField;
        set => otherInstructionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType ConsignorParty
    {
        get => consignorPartyField;
        set => consignorPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType CarrierParty
    {
        get => carrierPartyField;
        set => carrierPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType FreightForwarderParty
    {
        get => freightForwarderPartyField;
        set => freightForwarderPartyField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ShipmentType Shipment
    {
        get => shipmentField;
        set => shipmentField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType[] ExchangeRate
    {
        get => exchangeRateField;
        set => exchangeRateField = value;
    }

    /// <remarks />
    [XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }
}