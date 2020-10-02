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

        private IdType _idField;

        private UuidType _uUidField;

        private NoteType[] _noteField;

        private ReceivedQuantityType _receivedQuantityField;

        private ShortQuantityType _shortQuantityField;

        private ShortageActionCodeType _shortageActionCodeField;

        private RejectedQuantityType _rejectedQuantityField;

        private RejectReasonCodeType _rejectReasonCodeField;

        private RejectReasonType[] _rejectReasonField;

        private RejectActionCodeType _rejectActionCodeField;

        private QuantityDiscrepancyCodeType _quantityDiscrepancyCodeField;

        private OversupplyQuantityType _oversupplyQuantityField;

        private ReceivedDateType _receivedDateField;

        private TimingComplaintCodeType _timingComplaintCodeField;

        private TimingComplaintType _timingComplaintField;

        private OrderLineReferenceType _orderLineReferenceField;

        private LineReferenceType[] _despatchLineReferenceField;

        private DocumentReferenceType[] _documentReferenceField;

        private ItemType[] _itemField;

        private ShipmentType[] _shipmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UuidType Uuid
        {
            get
            {
                return _uUidField;
            }
            set
            {
                _uUidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedQuantityType ReceivedQuantity
        {
            get
            {
                return _receivedQuantityField;
            }
            set
            {
                _receivedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShortQuantityType ShortQuantity
        {
            get
            {
                return _shortQuantityField;
            }
            set
            {
                _shortQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShortageActionCodeType ShortageActionCode
        {
            get
            {
                return _shortageActionCodeField;
            }
            set
            {
                _shortageActionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectedQuantityType RejectedQuantity
        {
            get
            {
                return _rejectedQuantityField;
            }
            set
            {
                _rejectedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectReasonCodeType RejectReasonCode
        {
            get
            {
                return _rejectReasonCodeField;
            }
            set
            {
                _rejectReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RejectReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectReasonType[] RejectReason
        {
            get
            {
                return _rejectReasonField;
            }
            set
            {
                _rejectReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectActionCodeType RejectActionCode
        {
            get
            {
                return _rejectActionCodeField;
            }
            set
            {
                _rejectActionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityDiscrepancyCodeType QuantityDiscrepancyCode
        {
            get
            {
                return _quantityDiscrepancyCodeField;
            }
            set
            {
                _quantityDiscrepancyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OversupplyQuantityType OversupplyQuantity
        {
            get
            {
                return _oversupplyQuantityField;
            }
            set
            {
                _oversupplyQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedDateType ReceivedDate
        {
            get
            {
                return _receivedDateField;
            }
            set
            {
                _receivedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimingComplaintCodeType TimingComplaintCode
        {
            get
            {
                return _timingComplaintCodeField;
            }
            set
            {
                _timingComplaintCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimingComplaintType TimingComplaint
        {
            get
            {
                return _timingComplaintField;
            }
            set
            {
                _timingComplaintField = value;
            }
        }

        /// <remarks/>
        public OrderLineReferenceType OrderLineReference
        {
            get
            {
                return _orderLineReferenceField;
            }
            set
            {
                _orderLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return _despatchLineReferenceField;
            }
            set
            {
                _despatchLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return _documentReferenceField;
            }
            set
            {
                _documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public ItemType[] Item
        {
            get
            {
                return _itemField;
            }
            set
            {
                _itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Shipment")]
        public ShipmentType[] Shipment
        {
            get
            {
                return _shipmentField;
            }
            set
            {
                _shipmentField = value;
            }
        }
    }
}