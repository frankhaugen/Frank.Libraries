namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("BusinessClassificationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ClassificationSchemeType
    {

        private IdType _idField;

        private UuidType _uUidField;

        private LastRevisionDateType _lastRevisionDateField;

        private LastRevisionTimeType _lastRevisionTimeField;

        private NoteType[] _noteField;

        private NameType1 _nameField;

        private DescriptionType[] _descriptionField;

        private AgencyIdType _agencyIdField;

        private AgencyNameType _agencyNameField;

        private VersionIdType _versionIdField;

        private UriType _uRiField;

        private SchemeUriType _schemeUriField;

        private LanguageIdType _languageIdField;

        private ClassificationCategoryType[] _classificationCategoryField;

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
        public UuidType Uuid
        {
            get
            {
                return _uUidField;
            }
            set
            {
                _uUidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LastRevisionDateType LastRevisionDate
        {
            get
            {
                return _lastRevisionDateField;
            }
            set
            {
                _lastRevisionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LastRevisionTimeType LastRevisionTime
        {
            get
            {
                return _lastRevisionTimeField;
            }
            set
            {
                _lastRevisionTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AgencyIdType AgencyId
        {
            get
            {
                return _agencyIdField;
            }
            set
            {
                _agencyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AgencyNameType AgencyName
        {
            get
            {
                return _agencyNameField;
            }
            set
            {
                _agencyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VersionIdType VersionId
        {
            get
            {
                return _versionIdField;
            }
            set
            {
                _versionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UriType Uri
        {
            get
            {
                return _uRiField;
            }
            set
            {
                _uRiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SchemeUriType SchemeUri
        {
            get
            {
                return _schemeUriField;
            }
            set
            {
                _schemeUriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LanguageIdType LanguageId
        {
            get
            {
                return _languageIdField;
            }
            set
            {
                _languageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassificationCategory")]
        public ClassificationCategoryType[] ClassificationCategory
        {
            get
            {
                return _classificationCategoryField;
            }
            set
            {
                _classificationCategoryField = value;
            }
        }
    }
}