namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("MaritimeTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class MaritimeTransportType
    {

        private VesselIDType vesselIDField;

        private VesselNameType vesselNameField;

        private RadioCallSignIDType radioCallSignIDField;

        private ShipsRequirementsType[] shipsRequirementsField;

        private GrossTonnageMeasureType grossTonnageMeasureField;

        private NetTonnageMeasureType netTonnageMeasureField;

        private DocumentReferenceType registryCertificateDocumentReferenceField;

        private LocationType1 registryPortLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VesselIDType VesselID
        {
            get
            {
                return vesselIDField;
            }
            set
            {
                vesselIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VesselNameType VesselName
        {
            get
            {
                return vesselNameField;
            }
            set
            {
                vesselNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RadioCallSignIDType RadioCallSignID
        {
            get
            {
                return radioCallSignIDField;
            }
            set
            {
                radioCallSignIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipsRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShipsRequirementsType[] ShipsRequirements
        {
            get
            {
                return shipsRequirementsField;
            }
            set
            {
                shipsRequirementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossTonnageMeasureType GrossTonnageMeasure
        {
            get
            {
                return grossTonnageMeasureField;
            }
            set
            {
                grossTonnageMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetTonnageMeasureType NetTonnageMeasure
        {
            get
            {
                return netTonnageMeasureField;
            }
            set
            {
                netTonnageMeasureField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType RegistryCertificateDocumentReference
        {
            get
            {
                return registryCertificateDocumentReferenceField;
            }
            set
            {
                registryCertificateDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public LocationType1 RegistryPortLocation
        {
            get
            {
                return registryPortLocationField;
            }
            set
            {
                registryPortLocationField = value;
            }
        }
    }
}