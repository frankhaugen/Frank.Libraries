namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class HazardousGoodsTransitType
    {

        private TransportEmergencyCardCodeType _transportEmergencyCardCodeField;

        private PackingCriteriaCodeType _packingCriteriaCodeField;

        private HazardousRegulationCodeType _hazardousRegulationCodeField;

        private InhalationToxicityZoneCodeType _inhalationToxicityZoneCodeField;

        private TransportAuthorizationCodeType _transportAuthorizationCodeField;

        private TemperatureType _maximumTemperatureField;

        private TemperatureType _minimumTemperatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEmergencyCardCodeType TransportEmergencyCardCode
        {
            get
            {
                return _transportEmergencyCardCodeField;
            }
            set
            {
                _transportEmergencyCardCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackingCriteriaCodeType PackingCriteriaCode
        {
            get
            {
                return _packingCriteriaCodeField;
            }
            set
            {
                _packingCriteriaCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRegulationCodeType HazardousRegulationCode
        {
            get
            {
                return _hazardousRegulationCodeField;
            }
            set
            {
                _hazardousRegulationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InhalationToxicityZoneCodeType InhalationToxicityZoneCode
        {
            get
            {
                return _inhalationToxicityZoneCodeField;
            }
            set
            {
                _inhalationToxicityZoneCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportAuthorizationCodeType TransportAuthorizationCode
        {
            get
            {
                return _transportAuthorizationCodeField;
            }
            set
            {
                _transportAuthorizationCodeField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return _maximumTemperatureField;
            }
            set
            {
                _maximumTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return _minimumTemperatureField;
            }
            set
            {
                _minimumTemperatureField = value;
            }
        }
    }
}