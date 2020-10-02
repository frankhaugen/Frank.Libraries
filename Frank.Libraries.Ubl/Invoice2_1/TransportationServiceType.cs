namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportationServiceType
    {

        private TransportServiceCodeType transportServiceCodeField;

        private TariffClassCodeType tariffClassCodeField;

        private PriorityType priorityField;

        private FreightRateClassCodeType freightRateClassCodeField;

        private TransportationServiceDescriptionType[] transportationServiceDescriptionField;

        private TransportationServiceDetailsURIType transportationServiceDetailsURIField;

        private NominationDateType nominationDateField;

        private NominationTimeType nominationTimeField;

        private NameType1 nameField;

        private SequenceNumericType sequenceNumericField;

        private TransportEquipmentType[] transportEquipmentField;

        private TransportEquipmentType[] supportedTransportEquipmentField;

        private TransportEquipmentType[] unsupportedTransportEquipmentField;

        private CommodityClassificationType[] commodityClassificationField;

        private CommodityClassificationType[] supportedCommodityClassificationField;

        private CommodityClassificationType[] unsupportedCommodityClassificationField;

        private DimensionType totalCapacityDimensionField;

        private ShipmentStageType[] shipmentStageField;

        private TransportEventType[] transportEventField;

        private PartyType responsibleTransportServiceProviderPartyField;

        private EnvironmentalEmissionType[] environmentalEmissionField;

        private PeriodType estimatedDurationPeriodField;

        private ServiceFrequencyType[] scheduledServiceFrequencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportServiceCodeType TransportServiceCode
        {
            get
            {
                return transportServiceCodeField;
            }
            set
            {
                transportServiceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffClassCodeType TariffClassCode
        {
            get
            {
                return tariffClassCodeField;
            }
            set
            {
                tariffClassCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriorityType Priority
        {
            get
            {
                return priorityField;
            }
            set
            {
                priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreightRateClassCodeType FreightRateClassCode
        {
            get
            {
                return freightRateClassCodeField;
            }
            set
            {
                freightRateClassCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportationServiceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportationServiceDescriptionType[] TransportationServiceDescription
        {
            get
            {
                return transportationServiceDescriptionField;
            }
            set
            {
                transportationServiceDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportationServiceDetailsURIType TransportationServiceDetailsURI
        {
            get
            {
                return transportationServiceDetailsURIField;
            }
            set
            {
                transportationServiceDetailsURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationDateType NominationDate
        {
            get
            {
                return nominationDateField;
            }
            set
            {
                nominationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationTimeType NominationTime
        {
            get
            {
                return nominationTimeField;
            }
            set
            {
                nominationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return transportEquipmentField;
            }
            set
            {
                transportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedTransportEquipment")]
        public TransportEquipmentType[] SupportedTransportEquipment
        {
            get
            {
                return supportedTransportEquipmentField;
            }
            set
            {
                supportedTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnsupportedTransportEquipment")]
        public TransportEquipmentType[] UnsupportedTransportEquipment
        {
            get
            {
                return unsupportedTransportEquipmentField;
            }
            set
            {
                unsupportedTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification
        {
            get
            {
                return commodityClassificationField;
            }
            set
            {
                commodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedCommodityClassification")]
        public CommodityClassificationType[] SupportedCommodityClassification
        {
            get
            {
                return supportedCommodityClassificationField;
            }
            set
            {
                supportedCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnsupportedCommodityClassification")]
        public CommodityClassificationType[] UnsupportedCommodityClassification
        {
            get
            {
                return unsupportedCommodityClassificationField;
            }
            set
            {
                unsupportedCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        public DimensionType TotalCapacityDimension
        {
            get
            {
                return totalCapacityDimensionField;
            }
            set
            {
                totalCapacityDimensionField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
        public TransportEventType[] TransportEvent
        {
            get
            {
                return transportEventField;
            }
            set
            {
                transportEventField = value;
            }
        }

        /// <remarks/>
        public PartyType ResponsibleTransportServiceProviderParty
        {
            get
            {
                return responsibleTransportServiceProviderPartyField;
            }
            set
            {
                responsibleTransportServiceProviderPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
        public EnvironmentalEmissionType[] EnvironmentalEmission
        {
            get
            {
                return environmentalEmissionField;
            }
            set
            {
                environmentalEmissionField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDurationPeriod
        {
            get
            {
                return estimatedDurationPeriodField;
            }
            set
            {
                estimatedDurationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduledServiceFrequency")]
        public ServiceFrequencyType[] ScheduledServiceFrequency
        {
            get
            {
                return scheduledServiceFrequencyField;
            }
            set
            {
                scheduledServiceFrequencyField = value;
            }
        }
    }
}