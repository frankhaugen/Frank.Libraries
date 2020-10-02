namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ActivityFinalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class LocationType1
    {

        private IdType _idField;

        private DescriptionType[] _descriptionField;

        private ConditionsType[] _conditionsField;

        private CountrySubentityType _countrySubentityField;

        private CountrySubentityCodeType _countrySubentityCodeField;

        private LocationTypeCodeType _locationTypeCodeField;

        private InformationUriType _informationUriField;

        private NameType1 _nameField;

        private PeriodType[] _validityPeriodField;

        private AddressType _addressField;

        private LocationType1[] _subsidiaryLocationField;

        private LocationCoordinateType[] _locationCoordinateField;

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
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConditionsType[] Conditions
        {
            get
            {
                return _conditionsField;
            }
            set
            {
                _conditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentityType CountrySubentity
        {
            get
            {
                return _countrySubentityField;
            }
            set
            {
                _countrySubentityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentityCodeType CountrySubentityCode
        {
            get
            {
                return _countrySubentityCodeField;
            }
            set
            {
                _countrySubentityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LocationTypeCodeType LocationTypeCode
        {
            get
            {
                return _locationTypeCodeField;
            }
            set
            {
                _locationTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationUriType InformationUri
        {
            get
            {
                return _informationUriField;
            }
            set
            {
                _informationUriField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return _validityPeriodField;
            }
            set
            {
                _validityPeriodField = value;
            }
        }

        /// <remarks/>
        public AddressType Address
        {
            get
            {
                return _addressField;
            }
            set
            {
                _addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubsidiaryLocation")]
        public LocationType1[] SubsidiaryLocation
        {
            get
            {
                return _subsidiaryLocationField;
            }
            set
            {
                _subsidiaryLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationCoordinate")]
        public LocationCoordinateType[] LocationCoordinate
        {
            get
            {
                return _locationCoordinateField;
            }
            set
            {
                _locationCoordinateField = value;
            }
        }
    }
}