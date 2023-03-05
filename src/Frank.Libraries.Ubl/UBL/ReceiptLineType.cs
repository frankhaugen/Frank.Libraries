using System;
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
[XmlRoot("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ReceiptLineType
{
    private LineReferenceType[] despatchLineReferenceField;

    private DocumentReferenceType[] documentReferenceField;

    private IDType idField;

    private ItemType[] itemField;

    private NoteType[] noteField;

    private OrderLineReferenceType orderLineReferenceField;

    private OversupplyQuantityType oversupplyQuantityField;

    private QuantityDiscrepancyCodeType quantityDiscrepancyCodeField;

    private ReceivedDateType receivedDateField;

    private ReceivedQuantityType receivedQuantityField;

    private RejectActionCodeType rejectActionCodeField;

    private RejectedQuantityType rejectedQuantityField;

    private RejectReasonCodeType rejectReasonCodeField;

    private RejectReasonType[] rejectReasonField;

    private ShipmentType[] shipmentField;

    private ShortageActionCodeType shortageActionCodeField;

    private ShortQuantityType shortQuantityField;

    private TimingComplaintCodeType timingComplaintCodeField;

    private TimingComplaintType timingComplaintField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
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
    public ReceivedQuantityType ReceivedQuantity
    {
        get => receivedQuantityField;
        set => receivedQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShortQuantityType ShortQuantity
    {
        get => shortQuantityField;
        set => shortQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShortageActionCodeType ShortageActionCode
    {
        get => shortageActionCodeField;
        set => shortageActionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RejectedQuantityType RejectedQuantity
    {
        get => rejectedQuantityField;
        set => rejectedQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RejectReasonCodeType RejectReasonCode
    {
        get => rejectReasonCodeField;
        set => rejectReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement("RejectReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RejectReasonType[] RejectReason
    {
        get => rejectReasonField;
        set => rejectReasonField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RejectActionCodeType RejectActionCode
    {
        get => rejectActionCodeField;
        set => rejectActionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityDiscrepancyCodeType QuantityDiscrepancyCode
    {
        get => quantityDiscrepancyCodeField;
        set => quantityDiscrepancyCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OversupplyQuantityType OversupplyQuantity
    {
        get => oversupplyQuantityField;
        set => oversupplyQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReceivedDateType ReceivedDate
    {
        get => receivedDateField;
        set => receivedDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TimingComplaintCodeType TimingComplaintCode
    {
        get => timingComplaintCodeField;
        set => timingComplaintCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TimingComplaintType TimingComplaint
    {
        get => timingComplaintField;
        set => timingComplaintField = value;
    }

    /// <remarks />
    public OrderLineReferenceType OrderLineReference
    {
        get => orderLineReferenceField;
        set => orderLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DespatchLineReference")]
    public LineReferenceType[] DespatchLineReference
    {
        get => despatchLineReferenceField;
        set => despatchLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Item")]
    public ItemType[] Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    [XmlElement("Shipment")]
    public ShipmentType[] Shipment
    {
        get => shipmentField;
        set => shipmentField = value;
    }
}