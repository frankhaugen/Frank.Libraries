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

        private IdentificationIDType identificationIDField;

        private OccurrenceDateType occurrenceDateField;

        private OccurrenceTimeType occurrenceTimeField;

        private TypeCodeType typeCodeField;

        private DescriptionType[] descriptionField;

        private CompletionIndicatorType completionIndicatorField;

        private StatusType[] currentStatusField;

        private ContactType[] contactField;

        private LocationType1 occurenceLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentificationIDType IdentificationID
        {
            get
            {
                return identificationIDField;
            }
            set
            {
                identificationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OccurrenceDateType OccurrenceDate
        {
            get
            {
                return occurrenceDateField;
            }
            set
            {
                occurrenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OccurrenceTimeType OccurrenceTime
        {
            get
            {
                return occurrenceTimeField;
            }
            set
            {
                occurrenceTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TypeCodeType TypeCode
        {
            get
            {
                return typeCodeField;
            }
            set
            {
                typeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompletionIndicatorType CompletionIndicator
        {
            get
            {
                return completionIndicatorField;
            }
            set
            {
                completionIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrentStatus")]
        public StatusType[] CurrentStatus
        {
            get
            {
                return currentStatusField;
            }
            set
            {
                currentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public ContactType[] Contact
        {
            get
            {
                return contactField;
            }
            set
            {
                contactField = value;
            }
        }

        /// <remarks/>
        public LocationType1 OccurenceLocation
        {
            get
            {
                return occurenceLocationField;
            }
            set
            {
                occurenceLocationField = value;
            }
        }
    }
}