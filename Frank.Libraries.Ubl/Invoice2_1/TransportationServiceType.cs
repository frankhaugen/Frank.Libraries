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

        private TransportServiceCodeType _transportServiceCodeField;

        private TariffClassCodeType _tariffClassCodeField;

        private PriorityType _priorityField;

        private FreightRateClassCodeType _freightRateClassCodeField;

        private TransportationServiceDescriptionType[] _transportationServiceDescriptionField;

        private TransportationServiceDetailsUriType _transportationServiceDetailsUriField;

        private NominationDateType _nominationDateField;

        private NominationTimeType _nominationTimeField;

        private NameType1 _nameField;

        private SequenceNumericType _sequenceNumericField;

        private TransportEquipmentType[] _transportEquipmentField;

        private TransportEquipmentType[] _supportedTransportEquipmentField;

        private TransportEquipmentType[] _unsupportedTransportEquipmentField;

        private CommodityClassificationType[] _commodityClassificationField;

        private CommodityClassificationType[] _supportedCommodityClassificationField;

        private CommodityClassificationType[] _unsupportedCommodityClassificationField;

        private DimensionType _totalCapacityDimensionField;

        private ShipmentStageType[] _shipmentStageField;

        private TransportEventType[] _transportEventField;

        private PartyType _responsibleTransportServiceProviderPartyField;

        private EnvironmentalEmissionType[] _environmentalEmissionField;

        private PeriodType _estimatedDurationPeriodField;

        private ServiceFrequencyType[] _scheduledServiceFrequencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportServiceCodeType TransportServiceCode
        {
            get
            {
                return _transportServiceCodeField;
            }
            set
            {
                _transportServiceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TariffClassCodeType TariffClassCode
        {
            get
            {
                return _tariffClassCodeField;
            }
            set
            {
                _tariffClassCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriorityType Priority
        {
            get
            {
                return _priorityField;
            }
            set
            {
                _priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreightRateClassCodeType FreightRateClassCode
        {
            get
            {
                return _freightRateClassCodeField;
            }
            set
            {
                _freightRateClassCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportationServiceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportationServiceDescriptionType[] TransportationServiceDescription
        {
            get
            {
                return _transportationServiceDescriptionField;
            }
            set
            {
                _transportationServiceDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportationServiceDetailsUriType TransportationServiceDetailsUri
        {
            get
            {
                return _transportationServiceDetailsUriField;
            }
            set
            {
                _transportationServiceDetailsUriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationDateType NominationDate
        {
            get
            {
                return _nominationDateField;
            }
            set
            {
                _nominationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationTimeType NominationTime
        {
            get
            {
                return _nominationTimeField;
            }
            set
            {
                _nominationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return _transportEquipmentField;
            }
            set
            {
                _transportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedTransportEquipment")]
        public TransportEquipmentType[] SupportedTransportEquipment
        {
            get
            {
                return _supportedTransportEquipmentField;
            }
            set
            {
                _supportedTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnsupportedTransportEquipment")]
        public TransportEquipmentType[] UnsupportedTransportEquipment
        {
            get
            {
                return _unsupportedTransportEquipmentField;
            }
            set
            {
                _unsupportedTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification
        {
            get
            {
                return _commodityClassificationField;
            }
            set
            {
                _commodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedCommodityClassification")]
        public CommodityClassificationType[] SupportedCommodityClassification
        {
            get
            {
                return _supportedCommodityClassificationField;
            }
            set
            {
                _supportedCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnsupportedCommodityClassification")]
        public CommodityClassificationType[] UnsupportedCommodityClassification
        {
            get
            {
                return _unsupportedCommodityClassificationField;
            }
            set
            {
                _unsupportedCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        public DimensionType TotalCapacityDimension
        {
            get
            {
                return _totalCapacityDimensionField;
            }
            set
            {
                _totalCapacityDimensionField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
        public TransportEventType[] TransportEvent
        {
            get
            {
                return _transportEventField;
            }
            set
            {
                _transportEventField = value;
            }
        }

        /// <remarks/>
        public PartyType ResponsibleTransportServiceProviderParty
        {
            get
            {
                return _responsibleTransportServiceProviderPartyField;
            }
            set
            {
                _responsibleTransportServiceProviderPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
        public EnvironmentalEmissionType[] EnvironmentalEmission
        {
            get
            {
                return _environmentalEmissionField;
            }
            set
            {
                _environmentalEmissionField = value;
            }
        }

        /// <remarks/>
        public PeriodType EstimatedDurationPeriod
        {
            get
            {
                return _estimatedDurationPeriodField;
            }
            set
            {
                _estimatedDurationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduledServiceFrequency")]
        public ServiceFrequencyType[] ScheduledServiceFrequency
        {
            get
            {
                return _scheduledServiceFrequencyField;
            }
            set
            {
                _scheduledServiceFrequencyField = value;
            }
        }
    }
}