namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ReceiptLineType
    {

        private IDType idField;

        private UUIDType uUIDField;

        private NoteType[] noteField;

        private ReceivedQuantityType receivedQuantityField;

        private ShortQuantityType shortQuantityField;

        private ShortageActionCodeType shortageActionCodeField;

        private RejectedQuantityType rejectedQuantityField;

        private RejectReasonCodeType rejectReasonCodeField;

        private RejectReasonType[] rejectReasonField;

        private RejectActionCodeType rejectActionCodeField;

        private QuantityDiscrepancyCodeType quantityDiscrepancyCodeField;

        private OversupplyQuantityType oversupplyQuantityField;

        private ReceivedDateType receivedDateField;

        private TimingComplaintCodeType timingComplaintCodeField;

        private TimingComplaintType timingComplaintField;

        private OrderLineReferenceType orderLineReferenceField;

        private LineReferenceType[] despatchLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType[] itemField;

        private ShipmentType[] shipmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID
        {
            get
            {
                return uUIDField;
            }
            set
            {
                uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedQuantityType ReceivedQuantity
        {
            get
            {
                return receivedQuantityField;
            }
            set
            {
                receivedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShortQuantityType ShortQuantity
        {
            get
            {
                return shortQuantityField;
            }
            set
            {
                shortQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShortageActionCodeType ShortageActionCode
        {
            get
            {
                return shortageActionCodeField;
            }
            set
            {
                shortageActionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectedQuantityType RejectedQuantity
        {
            get
            {
                return rejectedQuantityField;
            }
            set
            {
                rejectedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectReasonCodeType RejectReasonCode
        {
            get
            {
                return rejectReasonCodeField;
            }
            set
            {
                rejectReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RejectReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectReasonType[] RejectReason
        {
            get
            {
                return rejectReasonField;
            }
            set
            {
                rejectReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectActionCodeType RejectActionCode
        {
            get
            {
                return rejectActionCodeField;
            }
            set
            {
                rejectActionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityDiscrepancyCodeType QuantityDiscrepancyCode
        {
            get
            {
                return quantityDiscrepancyCodeField;
            }
            set
            {
                quantityDiscrepancyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OversupplyQuantityType OversupplyQuantity
        {
            get
            {
                return oversupplyQuantityField;
            }
            set
            {
                oversupplyQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedDateType ReceivedDate
        {
            get
            {
                return receivedDateField;
            }
            set
            {
                receivedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimingComplaintCodeType TimingComplaintCode
        {
            get
            {
                return timingComplaintCodeField;
            }
            set
            {
                timingComplaintCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimingComplaintType TimingComplaint
        {
            get
            {
                return timingComplaintField;
            }
            set
            {
                timingComplaintField = value;
            }
        }

        /// <remarks/>
        public OrderLineReferenceType OrderLineReference
        {
            get
            {
                return orderLineReferenceField;
            }
            set
            {
                orderLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return despatchLineReferenceField;
            }
            set
            {
                despatchLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return documentReferenceField;
            }
            set
            {
                documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public ItemType[] Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Shipment")]
        public ShipmentType[] Shipment
        {
            get
            {
                return shipmentField;
            }
            set
            {
                shipmentField = value;
            }
        }
    }
}