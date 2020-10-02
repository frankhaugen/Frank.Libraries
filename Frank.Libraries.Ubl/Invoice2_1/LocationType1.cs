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

        private IDType idField;

        private DescriptionType[] descriptionField;

        private ConditionsType[] conditionsField;

        private CountrySubentityType countrySubentityField;

        private CountrySubentityCodeType countrySubentityCodeField;

        private LocationTypeCodeType locationTypeCodeField;

        private InformationURIType informationURIField;

        private NameType1 nameField;

        private PeriodType[] validityPeriodField;

        private AddressType addressField;

        private LocationType1[] subsidiaryLocationField;

        private LocationCoordinateType[] locationCoordinateField;

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
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConditionsType[] Conditions
        {
            get
            {
                return conditionsField;
            }
            set
            {
                conditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentityType CountrySubentity
        {
            get
            {
                return countrySubentityField;
            }
            set
            {
                countrySubentityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentityCodeType CountrySubentityCode
        {
            get
            {
                return countrySubentityCodeField;
            }
            set
            {
                countrySubentityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LocationTypeCodeType LocationTypeCode
        {
            get
            {
                return locationTypeCodeField;
            }
            set
            {
                locationTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationURIType InformationURI
        {
            get
            {
                return informationURIField;
            }
            set
            {
                informationURIField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return validityPeriodField;
            }
            set
            {
                validityPeriodField = value;
            }
        }

        /// <remarks/>
        public AddressType Address
        {
            get
            {
                return addressField;
            }
            set
            {
                addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubsidiaryLocation")]
        public LocationType1[] SubsidiaryLocation
        {
            get
            {
                return subsidiaryLocationField;
            }
            set
            {
                subsidiaryLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationCoordinate")]
        public LocationCoordinateType[] LocationCoordinate
        {
            get
            {
                return locationCoordinateField;
            }
            set
            {
                locationCoordinateField = value;
            }
        }
    }
}