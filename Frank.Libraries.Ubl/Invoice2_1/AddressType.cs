namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AddressType
    {

        private IdType _idField;

        private AddressTypeCodeType _addressTypeCodeField;

        private AddressFormatCodeType _addressFormatCodeField;

        private PostboxType _postboxField;

        private FloorType _floorField;

        private RoomType _roomField;

        private StreetNameType _streetNameField;

        private AdditionalStreetNameType _additionalStreetNameField;

        private BlockNameType _blockNameField;

        private BuildingNameType _buildingNameField;

        private BuildingNumberType _buildingNumberField;

        private InhouseMailType _inhouseMailField;

        private DepartmentType _departmentField;

        private MarkAttentionType _markAttentionField;

        private MarkCareType _markCareField;

        private PlotIdentificationType _plotIdentificationField;

        private CitySubdivisionNameType _citySubdivisionNameField;

        private CityNameType _cityNameField;

        private PostalZoneType _postalZoneField;

        private CountrySubentityType _countrySubentityField;

        private CountrySubentityCodeType _countrySubentityCodeField;

        private RegionType _regionField;

        private DistrictType _districtField;

        private TimezoneOffsetType _timezoneOffsetField;

        private AddressLineType[] _addressLineField;

        private CountryType _countryField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AddressTypeCodeType AddressTypeCode
        {
            get
            {
                return _addressTypeCodeField;
            }
            set
            {
                _addressTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AddressFormatCodeType AddressFormatCode
        {
            get
            {
                return _addressFormatCodeField;
            }
            set
            {
                _addressFormatCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PostboxType Postbox
        {
            get
            {
                return _postboxField;
            }
            set
            {
                _postboxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FloorType Floor
        {
            get
            {
                return _floorField;
            }
            set
            {
                _floorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RoomType Room
        {
            get
            {
                return _roomField;
            }
            set
            {
                _roomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StreetNameType StreetName
        {
            get
            {
                return _streetNameField;
            }
            set
            {
                _streetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalStreetNameType AdditionalStreetName
        {
            get
            {
                return _additionalStreetNameField;
            }
            set
            {
                _additionalStreetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BlockNameType BlockName
        {
            get
            {
                return _blockNameField;
            }
            set
            {
                _blockNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuildingNameType BuildingName
        {
            get
            {
                return _buildingNameField;
            }
            set
            {
                _buildingNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuildingNumberType BuildingNumber
        {
            get
            {
                return _buildingNumberField;
            }
            set
            {
                _buildingNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InhouseMailType InhouseMail
        {
            get
            {
                return _inhouseMailField;
            }
            set
            {
                _inhouseMailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DepartmentType Department
        {
            get
            {
                return _departmentField;
            }
            set
            {
                _departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkAttentionType MarkAttention
        {
            get
            {
                return _markAttentionField;
            }
            set
            {
                _markAttentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkCareType MarkCare
        {
            get
            {
                return _markCareField;
            }
            set
            {
                _markCareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlotIdentificationType PlotIdentification
        {
            get
            {
                return _plotIdentificationField;
            }
            set
            {
                _plotIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CitySubdivisionNameType CitySubdivisionName
        {
            get
            {
                return _citySubdivisionNameField;
            }
            set
            {
                _citySubdivisionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CityNameType CityName
        {
            get
            {
                return _cityNameField;
            }
            set
            {
                _cityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PostalZoneType PostalZone
        {
            get
            {
                return _postalZoneField;
            }
            set
            {
                _postalZoneField = value;
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
        public RegionType Region
        {
            get
            {
                return _regionField;
            }
            set
            {
                _regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DistrictType District
        {
            get
            {
                return _districtField;
            }
            set
            {
                _districtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimezoneOffsetType TimezoneOffset
        {
            get
            {
                return _timezoneOffsetField;
            }
            set
            {
                _timezoneOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressLine")]
        public AddressLineType[] AddressLine
        {
            get
            {
                return _addressLineField;
            }
            set
            {
                _addressLineField = value;
            }
        }

        /// <remarks/>
        public CountryType Country
        {
            get
            {
                return _countryField;
            }
            set
            {
                _countryField = value;
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