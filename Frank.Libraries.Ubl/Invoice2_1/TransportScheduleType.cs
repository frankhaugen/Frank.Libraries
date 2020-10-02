namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportSchedule", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportScheduleType
    {

        private SequenceNumericType sequenceNumericField;

        private ReferenceDateType referenceDateField;

        private ReferenceTimeType referenceTimeField;

        private ReliabilityPercentType reliabilityPercentField;

        private RemarksType[] remarksField;

        private LocationType1 statusLocationField;

        private TransportEventType actualArrivalTransportEventField;

        private TransportEventType actualDepartureTransportEventField;

        private TransportEventType estimatedDepartureTransportEventField;

        private TransportEventType estimatedArrivalTransportEventField;

        private TransportEventType plannedDepartureTransportEventField;

        private TransportEventType plannedArrivalTransportEventField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric
        {
            get
            {
                return sequenceNumericField;
            }
            set
            {
                sequenceNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceDateType ReferenceDate
        {
            get
            {
                return referenceDateField;
            }
            set
            {
                referenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceTimeType ReferenceTime
        {
            get
            {
                return referenceTimeField;
            }
            set
            {
                referenceTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReliabilityPercentType ReliabilityPercent
        {
            get
            {
                return reliabilityPercentField;
            }
            set
            {
                reliabilityPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return remarksField;
            }
            set
            {
                remarksField = value;
            }
        }

        /// <remarks/>
        public LocationType1 StatusLocation
        {
            get
            {
                return statusLocationField;
            }
            set
            {
                statusLocationField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualArrivalTransportEvent
        {
            get
            {
                return actualArrivalTransportEventField;
            }
            set
            {
                actualArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualDepartureTransportEvent
        {
            get
            {
                return actualDepartureTransportEventField;
            }
            set
            {
                actualDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedDepartureTransportEvent
        {
            get
            {
                return estimatedDepartureTransportEventField;
            }
            set
            {
                estimatedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedArrivalTransportEvent
        {
            get
            {
                return estimatedArrivalTransportEventField;
            }
            set
            {
                estimatedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedDepartureTransportEvent
        {
            get
            {
                return plannedDepartureTransportEventField;
            }
            set
            {
                plannedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedArrivalTransportEvent
        {
            get
            {
                return plannedArrivalTransportEventField;
            }
            set
            {
                plannedArrivalTransportEventField = value;
            }
        }
    }
}