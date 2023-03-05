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
[XmlRoot("DespatchLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DespatchLineType
{
    private BackorderQuantityType backorderQuantityField;

    private BackorderReasonType[] backorderReasonField;

    private DeliveredQuantityType deliveredQuantityField;

    private DocumentReferenceType[] documentReferenceField;

    private IDType idField;

    private ItemType itemField;

    private LineStatusCodeType lineStatusCodeField;

    private NoteType[] noteField;

    private OrderLineReferenceType[] orderLineReferenceField;

    private OutstandingQuantityType outstandingQuantityField;

    private OutstandingReasonType[] outstandingReasonField;

    private OversupplyQuantityType oversupplyQuantityField;

    private ShipmentType[] shipmentField;

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
    public LineStatusCodeType LineStatusCode
    {
        get => lineStatusCodeField;
        set => lineStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeliveredQuantityType DeliveredQuantity
    {
        get => deliveredQuantityField;
        set => deliveredQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BackorderQuantityType BackorderQuantity
    {
        get => backorderQuantityField;
        set => backorderQuantityField = value;
    }

    /// <remarks />
    [XmlElement("BackorderReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BackorderReasonType[] BackorderReason
    {
        get => backorderReasonField;
        set => backorderReasonField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OutstandingQuantityType OutstandingQuantity
    {
        get => outstandingQuantityField;
        set => outstandingQuantityField = value;
    }

    /// <remarks />
    [XmlElement("OutstandingReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OutstandingReasonType[] OutstandingReason
    {
        get => outstandingReasonField;
        set => outstandingReasonField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OversupplyQuantityType OversupplyQuantity
    {
        get => oversupplyQuantityField;
        set => oversupplyQuantityField = value;
    }

    /// <remarks />
    [XmlElement("OrderLineReference")]
    public OrderLineReferenceType[] OrderLineReference
    {
        get => orderLineReferenceField;
        set => orderLineReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public ItemType Item
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