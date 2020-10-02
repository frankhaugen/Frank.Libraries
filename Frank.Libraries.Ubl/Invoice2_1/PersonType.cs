namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CrewMemberPerson", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PersonType
    {

        private IdType _idField;

        private FirstNameType _firstNameField;

        private FamilyNameType _familyNameField;

        private TitleType _titleField;

        private MiddleNameType _middleNameField;

        private OtherNameType _otherNameField;

        private NameSuffixType _nameSuffixField;

        private JobTitleType _jobTitleField;

        private NationalityIdType _nationalityIdField;

        private GenderCodeType _genderCodeField;

        private BirthDateType _birthDateField;

        private BirthplaceNameType _birthplaceNameField;

        private OrganizationDepartmentType _organizationDepartmentField;

        private ContactType _contactField;

        private FinancialAccountType _financialAccountField;

        private DocumentReferenceType[] _identityDocumentReferenceField;

        private AddressType _residenceAddressField;

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
        public FirstNameType FirstName
        {
            get
            {
                return _firstNameField;
            }
            set
            {
                _firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FamilyNameType FamilyName
        {
            get
            {
                return _familyNameField;
            }
            set
            {
                _familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TitleType Title
        {
            get
            {
                return _titleField;
            }
            set
            {
                _titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MiddleNameType MiddleName
        {
            get
            {
                return _middleNameField;
            }
            set
            {
                _middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OtherNameType OtherName
        {
            get
            {
                return _otherNameField;
            }
            set
            {
                _otherNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameSuffixType NameSuffix
        {
            get
            {
                return _nameSuffixField;
            }
            set
            {
                _nameSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JobTitleType JobTitle
        {
            get
            {
                return _jobTitleField;
            }
            set
            {
                _jobTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NationalityIdType NationalityId
        {
            get
            {
                return _nationalityIdField;
            }
            set
            {
                _nationalityIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GenderCodeType GenderCode
        {
            get
            {
                return _genderCodeField;
            }
            set
            {
                _genderCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BirthDateType BirthDate
        {
            get
            {
                return _birthDateField;
            }
            set
            {
                _birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BirthplaceNameType BirthplaceName
        {
            get
            {
                return _birthplaceNameField;
            }
            set
            {
                _birthplaceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrganizationDepartmentType OrganizationDepartment
        {
            get
            {
                return _organizationDepartmentField;
            }
            set
            {
                _organizationDepartmentField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return _contactField;
            }
            set
            {
                _contactField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return _financialAccountField;
            }
            set
            {
                _financialAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentityDocumentReference")]
        public DocumentReferenceType[] IdentityDocumentReference
        {
            get
            {
                return _identityDocumentReferenceField;
            }
            set
            {
                _identityDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public AddressType ResidenceAddress
        {
            get
            {
                return _residenceAddressField;
            }
            set
            {
                _residenceAddressField = value;
            }
        }
    }
}