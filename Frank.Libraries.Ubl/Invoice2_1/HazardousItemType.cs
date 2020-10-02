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

        private IDType idField;

        private PlacardNotationType placardNotationField;

        private PlacardEndorsementType placardEndorsementField;

        private AdditionalInformationType[] additionalInformationField;

        private UNDGCodeType uNDGCodeField;

        private EmergencyProceduresCodeType emergencyProceduresCodeField;

        private MedicalFirstAidGuideCodeType medicalFirstAidGuideCodeField;

        private TechnicalNameType technicalNameField;

        private CategoryNameType categoryNameField;

        private HazardousCategoryCodeType hazardousCategoryCodeField;

        private UpperOrangeHazardPlacardIDType upperOrangeHazardPlacardIDField;

        private LowerOrangeHazardPlacardIDType lowerOrangeHazardPlacardIDField;

        private MarkingIDType markingIDField;

        private HazardClassIDType hazardClassIDField;

        private NetWeightMeasureType netWeightMeasureField;

        private NetVolumeMeasureType netVolumeMeasureField;

        private QuantityType2 quantityField;

        private PartyType contactPartyField;

        private SecondaryHazardType[] secondaryHazardField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private TemperatureType emergencyTemperatureField;

        private TemperatureType flashpointTemperatureField;

        private TemperatureType[] additionalTemperatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlacardNotationType PlacardNotation
        {
            get
            {
                return placardNotationField;
            }
            set
            {
                placardNotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlacardEndorsementType PlacardEndorsement
        {
            get
            {
                return placardEndorsementField;
            }
            set
            {
                placardEndorsementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalInformationType[] AdditionalInformation
        {
            get
            {
                return additionalInformationField;
            }
            set
            {
                additionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UNDGCodeType UNDGCode
        {
            get
            {
                return uNDGCodeField;
            }
            set
            {
                uNDGCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmergencyProceduresCodeType EmergencyProceduresCode
        {
            get
            {
                return emergencyProceduresCodeField;
            }
            set
            {
                emergencyProceduresCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MedicalFirstAidGuideCodeType MedicalFirstAidGuideCode
        {
            get
            {
                return medicalFirstAidGuideCodeField;
            }
            set
            {
                medicalFirstAidGuideCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TechnicalNameType TechnicalName
        {
            get
            {
                return technicalNameField;
            }
            set
            {
                technicalNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CategoryNameType CategoryName
        {
            get
            {
                return categoryNameField;
            }
            set
            {
                categoryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousCategoryCodeType HazardousCategoryCode
        {
            get
            {
                return hazardousCategoryCodeField;
            }
            set
            {
                hazardousCategoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UpperOrangeHazardPlacardIDType UpperOrangeHazardPlacardID
        {
            get
            {
                return upperOrangeHazardPlacardIDField;
            }
            set
            {
                upperOrangeHazardPlacardIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowerOrangeHazardPlacardIDType LowerOrangeHazardPlacardID
        {
            get
            {
                return lowerOrangeHazardPlacardIDField;
            }
            set
            {
                lowerOrangeHazardPlacardIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkingIDType MarkingID
        {
            get
            {
                return markingIDField;
            }
            set
            {
                markingIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardClassIDType HazardClassID
        {
            get
            {
                return hazardClassIDField;
            }
            set
            {
                hazardClassIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return netWeightMeasureField;
            }
            set
            {
                netWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return netVolumeMeasureField;
            }
            set
            {
                netVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }

        /// <remarks/>
        public PartyType ContactParty
        {
            get
            {
                return contactPartyField;
            }
            set
            {
                contactPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SecondaryHazard")]
        public SecondaryHazardType[] SecondaryHazard
        {
            get
            {
                return secondaryHazardField;
            }
            set
            {
                secondaryHazardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return hazardousGoodsTransitField;
            }
            set
            {
                hazardousGoodsTransitField = value;
            }
        }

        /// <remarks/>
        public TemperatureType EmergencyTemperature
        {
            get
            {
                return emergencyTemperatureField;
            }
            set
            {
                emergencyTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType FlashpointTemperature
        {
            get
            {
                return flashpointTemperatureField;
            }
            set
            {
                flashpointTemperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalTemperature")]
        public TemperatureType[] AdditionalTemperature
        {
            get
            {
                return additionalTemperatureField;
            }
            set
            {
                additionalTemperatureField = value;
            }
        }
    }
}