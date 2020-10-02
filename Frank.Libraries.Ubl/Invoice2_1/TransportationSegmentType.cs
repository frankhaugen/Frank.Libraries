namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportationSegmentType
    {

        private SequenceNumericType _sequenceNumericField;

        private TransportExecutionPlanReferenceIdType _transportExecutionPlanReferenceIdField;

        private TransportationServiceType _transportationServiceField;

        private PartyType _transportServiceProviderPartyField;

        private ConsignmentType _referencedConsignmentField;

        private ShipmentStageType[] _shipmentStageField;

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
        public TransportExecutionPlanReferenceIdType TransportExecutionPlanReferenceId
        {
            get
            {
                return _transportExecutionPlanReferenceIdField;
            }
            set
            {
                _transportExecutionPlanReferenceIdField = value;
            }
        }

        /// <remarks/>
        public TransportationServiceType TransportationService
        {
            get
            {
                return _transportationServiceField;
            }
            set
            {
                _transportationServiceField = value;
            }
        }

        /// <remarks/>
        public PartyType TransportServiceProviderParty
        {
            get
            {
                return _transportServiceProviderPartyField;
            }
            set
            {
                _transportServiceProviderPartyField = value;
            }
        }

        /// <remarks/>
        public ConsignmentType ReferencedConsignment
        {
            get
            {
                return _referencedConsignmentField;
            }
            set
            {
                _referencedConsignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return _shipmentStageField;
            }
            set
            {
                _shipmentStageField = value;
            }
        }
    }
}