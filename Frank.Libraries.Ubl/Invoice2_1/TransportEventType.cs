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

        private IdentificationIDType identificationIDField;

        private OccurrenceDateType occurrenceDateField;

        private OccurrenceTimeType occurrenceTimeField;

        private TransportEventTypeCodeType transportEventTypeCodeField;

        private DescriptionType[] descriptionField;

        private CompletionIndicatorType completionIndicatorField;

        private ShipmentType reportedShipmentField;

        private StatusType[] currentStatusField;

        private ContactType[] contactField;

        private LocationType1 locationField;

        private SignatureType signatureField;

        private PeriodType[] periodField;

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
        public TransportEventTypeCodeType TransportEventTypeCode
        {
            get
            {
                return transportEventTypeCodeField;
            }
            set
            {
                transportEventTypeCodeField = value;
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
        public ShipmentType ReportedShipment
        {
            get
            {
                return reportedShipmentField;
            }
            set
            {
                reportedShipmentField = value;
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
        public LocationType1 Location
        {
            get
            {
                return locationField;
            }
            set
            {
                locationField = value;
            }
        }

        /// <remarks/>
        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Period")]
        public PeriodType[] Period
        {
            get
            {
                return periodField;
            }
            set
            {
                periodField = value;
            }
        }
    }
}