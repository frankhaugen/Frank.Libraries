namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Event", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EventType
    {

        private IdentificationIdType _identificationIdField;

        private OccurrenceDateType _occurrenceDateField;

        private OccurrenceTimeType _occurrenceTimeField;

        private TypeCodeType _typeCodeField;

        private DescriptionType[] _descriptionField;

        private CompletionIndicatorType _completionIndicatorField;

        private StatusType[] _currentStatusField;

        private ContactType[] _contactField;

        private LocationType1 _occurenceLocationField;

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
        public TypeCodeType TypeCode
        {
            get
            {
                return _typeCodeField;
            }
            set
            {
                _typeCodeField = value;
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
        public LocationType1 OccurenceLocation
        {
            get
            {
                return _occurenceLocationField;
            }
            set
            {
                _occurenceLocationField = value;
            }
        }
    }
}