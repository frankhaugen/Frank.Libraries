namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("HazardousItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class HazardousItemType
    {

        private IdType _idField;

        private PlacardNotationType _placardNotationField;

        private PlacardEndorsementType _placardEndorsementField;

        private AdditionalInformationType[] _additionalInformationField;

        private UndgCodeType _uNdgCodeField;

        private EmergencyProceduresCodeType _emergencyProceduresCodeField;

        private MedicalFirstAidGuideCodeType _medicalFirstAidGuideCodeField;

        private TechnicalNameType _technicalNameField;

        private CategoryNameType _categoryNameField;

        private HazardousCategoryCodeType _hazardousCategoryCodeField;

        private UpperOrangeHazardPlacardIdType _upperOrangeHazardPlacardIdField;

        private LowerOrangeHazardPlacardIdType _lowerOrangeHazardPlacardIdField;

        private MarkingIdType _markingIdField;

        private HazardClassIdType _hazardClassIdField;

        private NetWeightMeasureType _netWeightMeasureField;

        private NetVolumeMeasureType _netVolumeMeasureField;

        private QuantityType2 _quantityField;

        private PartyType _contactPartyField;

        private SecondaryHazardType[] _secondaryHazardField;

        private HazardousGoodsTransitType[] _hazardousGoodsTransitField;

        private TemperatureType _emergencyTemperatureField;

        private TemperatureType _flashpointTemperatureField;

        private TemperatureType[] _additionalTemperatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlacardNotationType PlacardNotation
        {
            get
            {
                return _placardNotationField;
            }
            set
            {
                _placardNotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlacardEndorsementType PlacardEndorsement
        {
            get
            {
                return _placardEndorsementField;
            }
            set
            {
                _placardEndorsementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalInformationType[] AdditionalInformation
        {
            get
            {
                return _additionalInformationField;
            }
            set
            {
                _additionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UndgCodeType UndgCode
        {
            get
            {
                return _uNdgCodeField;
            }
            set
            {
                _uNdgCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmergencyProceduresCodeType EmergencyProceduresCode
        {
            get
            {
                return _emergencyProceduresCodeField;
            }
            set
            {
                _emergencyProceduresCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MedicalFirstAidGuideCodeType MedicalFirstAidGuideCode
        {
            get
            {
                return _medicalFirstAidGuideCodeField;
            }
            set
            {
                _medicalFirstAidGuideCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TechnicalNameType TechnicalName
        {
            get
            {
                return _technicalNameField;
            }
            set
            {
                _technicalNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CategoryNameType CategoryName
        {
            get
            {
                return _categoryNameField;
            }
            set
            {
                _categoryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousCategoryCodeType HazardousCategoryCode
        {
            get
            {
                return _hazardousCategoryCodeField;
            }
            set
            {
                _hazardousCategoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UpperOrangeHazardPlacardIdType UpperOrangeHazardPlacardId
        {
            get
            {
                return _upperOrangeHazardPlacardIdField;
            }
            set
            {
                _upperOrangeHazardPlacardIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowerOrangeHazardPlacardIdType LowerOrangeHazardPlacardId
        {
            get
            {
                return _lowerOrangeHazardPlacardIdField;
            }
            set
            {
                _lowerOrangeHazardPlacardIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkingIdType MarkingId
        {
            get
            {
                return _markingIdField;
            }
            set
            {
                _markingIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardClassIdType HazardClassId
        {
            get
            {
                return _hazardClassIdField;
            }
            set
            {
                _hazardClassIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return _netWeightMeasureField;
            }
            set
            {
                _netWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return _netVolumeMeasureField;
            }
            set
            {
                _netVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity
        {
            get
            {
                return _quantityField;
            }
            set
            {
                _quantityField = value;
            }
        }

        /// <remarks/>
        public PartyType ContactParty
        {
            get
            {
                return _contactPartyField;
            }
            set
            {
                _contactPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SecondaryHazard")]
        public SecondaryHazardType[] SecondaryHazard
        {
            get
            {
                return _secondaryHazardField;
            }
            set
            {
                _secondaryHazardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return _hazardousGoodsTransitField;
            }
            set
            {
                _hazardousGoodsTransitField = value;
            }
        }

        /// <remarks/>
        public TemperatureType EmergencyTemperature
        {
            get
            {
                return _emergencyTemperatureField;
            }
            set
            {
                _emergencyTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType FlashpointTemperature
        {
            get
            {
                return _flashpointTemperatureField;
            }
            set
            {
                _flashpointTemperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalTemperature")]
        public TemperatureType[] AdditionalTemperature
        {
            get
            {
                return _additionalTemperatureField;
            }
            set
            {
                _additionalTemperatureField = value;
            }
        }
    }
}