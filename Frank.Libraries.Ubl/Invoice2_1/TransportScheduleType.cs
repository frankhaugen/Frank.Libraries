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

        private SequenceNumericType _sequenceNumericField;

        private ReferenceDateType _referenceDateField;

        private ReferenceTimeType _referenceTimeField;

        private ReliabilityPercentType _reliabilityPercentField;

        private RemarksType[] _remarksField;

        private LocationType1 _statusLocationField;

        private TransportEventType _actualArrivalTransportEventField;

        private TransportEventType _actualDepartureTransportEventField;

        private TransportEventType _estimatedDepartureTransportEventField;

        private TransportEventType _estimatedArrivalTransportEventField;

        private TransportEventType _plannedDepartureTransportEventField;

        private TransportEventType _plannedArrivalTransportEventField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric
        {
            get
            {
                return _sequenceNumericField;
            }
            set
            {
                _sequenceNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceDateType ReferenceDate
        {
            get
            {
                return _referenceDateField;
            }
            set
            {
                _referenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceTimeType ReferenceTime
        {
            get
            {
                return _referenceTimeField;
            }
            set
            {
                _referenceTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReliabilityPercentType ReliabilityPercent
        {
            get
            {
                return _reliabilityPercentField;
            }
            set
            {
                _reliabilityPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return _remarksField;
            }
            set
            {
                _remarksField = value;
            }
        }

        /// <remarks/>
        public LocationType1 StatusLocation
        {
            get
            {
                return _statusLocationField;
            }
            set
            {
                _statusLocationField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualArrivalTransportEvent
        {
            get
            {
                return _actualArrivalTransportEventField;
            }
            set
            {
                _actualArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualDepartureTransportEvent
        {
            get
            {
                return _actualDepartureTransportEventField;
            }
            set
            {
                _actualDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedDepartureTransportEvent
        {
            get
            {
                return _estimatedDepartureTransportEventField;
            }
            set
            {
                _estimatedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedArrivalTransportEvent
        {
            get
            {
                return _estimatedArrivalTransportEventField;
            }
            set
            {
                _estimatedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedDepartureTransportEvent
        {
            get
            {
                return _plannedDepartureTransportEventField;
            }
            set
            {
                _plannedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedArrivalTransportEvent
        {
            get
            {
                return _plannedArrivalTransportEventField;
            }
            set
            {
                _plannedArrivalTransportEventField = value;
            }
        }
    }
}