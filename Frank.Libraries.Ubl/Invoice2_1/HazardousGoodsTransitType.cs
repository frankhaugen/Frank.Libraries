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

        private TransportEmergencyCardCodeType transportEmergencyCardCodeField;

        private PackingCriteriaCodeType packingCriteriaCodeField;

        private HazardousRegulationCodeType hazardousRegulationCodeField;

        private InhalationToxicityZoneCodeType inhalationToxicityZoneCodeField;

        private TransportAuthorizationCodeType transportAuthorizationCodeField;

        private TemperatureType maximumTemperatureField;

        private TemperatureType minimumTemperatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEmergencyCardCodeType TransportEmergencyCardCode
        {
            get
            {
                return transportEmergencyCardCodeField;
            }
            set
            {
                transportEmergencyCardCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackingCriteriaCodeType PackingCriteriaCode
        {
            get
            {
                return packingCriteriaCodeField;
            }
            set
            {
                packingCriteriaCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRegulationCodeType HazardousRegulationCode
        {
            get
            {
                return hazardousRegulationCodeField;
            }
            set
            {
                hazardousRegulationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InhalationToxicityZoneCodeType InhalationToxicityZoneCode
        {
            get
            {
                return inhalationToxicityZoneCodeField;
            }
            set
            {
                inhalationToxicityZoneCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportAuthorizationCodeType TransportAuthorizationCode
        {
            get
            {
                return transportAuthorizationCodeField;
            }
            set
            {
                transportAuthorizationCodeField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return maximumTemperatureField;
            }
            set
            {
                maximumTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return minimumTemperatureField;
            }
            set
            {
                minimumTemperatureField = value;
            }
        }
    }
}