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

        private VesselIdType _vesselIdField;

        private VesselNameType _vesselNameField;

        private RadioCallSignIdType _radioCallSignIdField;

        private ShipsRequirementsType[] _shipsRequirementsField;

        private GrossTonnageMeasureType _grossTonnageMeasureField;

        private NetTonnageMeasureType _netTonnageMeasureField;

        private DocumentReferenceType _registryCertificateDocumentReferenceField;

        private LocationType1 _registryPortLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VesselIdType VesselId
        {
            get
            {
                return _vesselIdField;
            }
            set
            {
                _vesselIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VesselNameType VesselName
        {
            get
            {
                return _vesselNameField;
            }
            set
            {
                _vesselNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RadioCallSignIdType RadioCallSignId
        {
            get
            {
                return _radioCallSignIdField;
            }
            set
            {
                _radioCallSignIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipsRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShipsRequirementsType[] ShipsRequirements
        {
            get
            {
                return _shipsRequirementsField;
            }
            set
            {
                _shipsRequirementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossTonnageMeasureType GrossTonnageMeasure
        {
            get
            {
                return _grossTonnageMeasureField;
            }
            set
            {
                _grossTonnageMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetTonnageMeasureType NetTonnageMeasure
        {
            get
            {
                return _netTonnageMeasureField;
            }
            set
            {
                _netTonnageMeasureField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType RegistryCertificateDocumentReference
        {
            get
            {
                return _registryCertificateDocumentReferenceField;
            }
            set
            {
                _registryCertificateDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public LocationType1 RegistryPortLocation
        {
            get
            {
                return _registryPortLocationField;
            }
            set
            {
                _registryPortLocationField = value;
            }
        }
    }
}