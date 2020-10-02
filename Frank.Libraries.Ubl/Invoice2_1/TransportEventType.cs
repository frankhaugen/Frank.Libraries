namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AcceptanceTransportEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportEventType
    {

        private IdentificationIdType _identificationIdField;

        private OccurrenceDateType _occurrenceDateField;

        private OccurrenceTimeType _occurrenceTimeField;

        private TransportEventTypeCodeType _transportEventTypeCodeField;

        private DescriptionType[] _descriptionField;

        private CompletionIndicatorType _completionIndicatorField;

        private ShipmentType _reportedShipmentField;

        private StatusType[] _currentStatusField;

        private ContactType[] _contactField;

        private LocationType1 _locationField;

        private SignatureType _signatureField;

        private PeriodType[] _periodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentificationIdType IdentificationId
        {
            get
            {
                return _identificationIdField;
            }
            set
            {
                _identificationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OccurrenceDateType OccurrenceDate
        {
            get
            {
                return _occurrenceDateField;
            }
            set
            {
                _occurrenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OccurrenceTimeType OccurrenceTime
        {
            get
            {
                return _occurrenceTimeField;
            }
            set
            {
                _occurrenceTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEventTypeCodeType TransportEventTypeCode
        {
            get
            {
                return _transportEventTypeCodeField;
            }
            set
            {
                _transportEventTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompletionIndicatorType CompletionIndicator
        {
            get
            {
                return _completionIndicatorField;
            }
            set
            {
                _completionIndicatorField = value;
            }
        }

        /// <remarks/>
        public ShipmentType ReportedShipment
        {
            get
            {
                return _reportedShipmentField;
            }
            set
            {
                _reportedShipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrentStatus")]
        public StatusType[] CurrentStatus
        {
            get
            {
                return _currentStatusField;
            }
            set
            {
                _currentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public ContactType[] Contact
        {
            get
            {
                return _contactField;
            }
            set
            {
                _contactField = value;
            }
        }

        /// <remarks/>
        public LocationType1 Location
        {
            get
            {
                return _locationField;
            }
            set
            {
                _locationField = value;
            }
        }

        /// <remarks/>
        public SignatureType Signature
        {
            get
            {
                return _signatureField;
            }
            set
            {
                _signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Period")]
        public PeriodType[] Period
        {
            get
            {
                return _periodField;
            }
            set
            {
                _periodField = value;
            }
        }
    }
}