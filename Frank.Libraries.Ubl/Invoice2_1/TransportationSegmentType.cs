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

        private SequenceNumericType sequenceNumericField;

        private TransportExecutionPlanReferenceIDType transportExecutionPlanReferenceIDField;

        private TransportationServiceType transportationServiceField;

        private PartyType transportServiceProviderPartyField;

        private ConsignmentType referencedConsignmentField;

        private ShipmentStageType[] shipmentStageField;

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
        public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID
        {
            get
            {
                return transportExecutionPlanReferenceIDField;
            }
            set
            {
                transportExecutionPlanReferenceIDField = value;
            }
        }

        /// <remarks/>
        public TransportationServiceType TransportationService
        {
            get
            {
                return transportationServiceField;
            }
            set
            {
                transportationServiceField = value;
            }
        }

        /// <remarks/>
        public PartyType TransportServiceProviderParty
        {
            get
            {
                return transportServiceProviderPartyField;
            }
            set
            {
                transportServiceProviderPartyField = value;
            }
        }

        /// <remarks/>
        public ConsignmentType ReferencedConsignment
        {
            get
            {
                return referencedConsignmentField;
            }
            set
            {
                referencedConsignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return shipmentStageField;
            }
            set
            {
                shipmentStageField = value;
            }
        }
    }
}