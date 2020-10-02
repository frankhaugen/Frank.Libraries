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

        private IDType idField;

        private FirstNameType firstNameField;

        private FamilyNameType familyNameField;

        private TitleType titleField;

        private MiddleNameType middleNameField;

        private OtherNameType otherNameField;

        private NameSuffixType nameSuffixField;

        private JobTitleType jobTitleField;

        private NationalityIDType nationalityIDField;

        private GenderCodeType genderCodeField;

        private BirthDateType birthDateField;

        private BirthplaceNameType birthplaceNameField;

        private OrganizationDepartmentType organizationDepartmentField;

        private ContactType contactField;

        private FinancialAccountType financialAccountField;

        private DocumentReferenceType[] identityDocumentReferenceField;

        private AddressType residenceAddressField;

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
        public FirstNameType FirstName
        {
            get
            {
                return firstNameField;
            }
            set
            {
                firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FamilyNameType FamilyName
        {
            get
            {
                return familyNameField;
            }
            set
            {
                familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TitleType Title
        {
            get
            {
                return titleField;
            }
            set
            {
                titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MiddleNameType MiddleName
        {
            get
            {
                return middleNameField;
            }
            set
            {
                middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OtherNameType OtherName
        {
            get
            {
                return otherNameField;
            }
            set
            {
                otherNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameSuffixType NameSuffix
        {
            get
            {
                return nameSuffixField;
            }
            set
            {
                nameSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JobTitleType JobTitle
        {
            get
            {
                return jobTitleField;
            }
            set
            {
                jobTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NationalityIDType NationalityID
        {
            get
            {
                return nationalityIDField;
            }
            set
            {
                nationalityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GenderCodeType GenderCode
        {
            get
            {
                return genderCodeField;
            }
            set
            {
                genderCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BirthDateType BirthDate
        {
            get
            {
                return birthDateField;
            }
            set
            {
                birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BirthplaceNameType BirthplaceName
        {
            get
            {
                return birthplaceNameField;
            }
            set
            {
                birthplaceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrganizationDepartmentType OrganizationDepartment
        {
            get
            {
                return organizationDepartmentField;
            }
            set
            {
                organizationDepartmentField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return contactField;
            }
            set
            {
                contactField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return financialAccountField;
            }
            set
            {
                financialAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentityDocumentReference")]
        public DocumentReferenceType[] IdentityDocumentReference
        {
            get
            {
                return identityDocumentReferenceField;
            }
            set
            {
                identityDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public AddressType ResidenceAddress
        {
            get
            {
                return residenceAddressField;
            }
            set
            {
                residenceAddressField = value;
            }
        }
    }
}