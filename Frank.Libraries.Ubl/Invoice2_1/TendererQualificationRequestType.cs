namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TendererQualificationRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TendererQualificationRequestType
    {

        private CompanyLegalFormCodeType _companyLegalFormCodeField;

        private CompanyLegalFormType _companyLegalFormField;

        private PersonalSituationType[] _personalSituationField;

        private OperatingYearsQuantityType _operatingYearsQuantityField;

        private EmployeeQuantityType _employeeQuantityField;

        private DescriptionType[] _descriptionField;

        private ClassificationSchemeType[] _requiredBusinessClassificationSchemeField;

        private EvaluationCriterionType[] _technicalEvaluationCriterionField;

        private EvaluationCriterionType[] _financialEvaluationCriterionField;

        private TendererRequirementType[] _specificTendererRequirementField;

        private EconomicOperatorRoleType[] _economicOperatorRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormCodeType CompanyLegalFormCode
        {
            get
            {
                return _companyLegalFormCodeField;
            }
            set
            {
                _companyLegalFormCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormType CompanyLegalForm
        {
            get
            {
                return _companyLegalFormField;
            }
            set
            {
                _companyLegalFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PersonalSituationType[] PersonalSituation
        {
            get
            {
                return _personalSituationField;
            }
            set
            {
                _personalSituationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OperatingYearsQuantityType OperatingYearsQuantity
        {
            get
            {
                return _operatingYearsQuantityField;
            }
            set
            {
                _operatingYearsQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmployeeQuantityType EmployeeQuantity
        {
            get
            {
                return _employeeQuantityField;
            }
            set
            {
                _employeeQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("RequiredBusinessClassificationScheme")]
        public ClassificationSchemeType[] RequiredBusinessClassificationScheme
        {
            get
            {
                return _requiredBusinessClassificationSchemeField;
            }
            set
            {
                _requiredBusinessClassificationSchemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalEvaluationCriterion")]
        public EvaluationCriterionType[] TechnicalEvaluationCriterion
        {
            get
            {
                return _technicalEvaluationCriterionField;
            }
            set
            {
                _technicalEvaluationCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinancialEvaluationCriterion")]
        public EvaluationCriterionType[] FinancialEvaluationCriterion
        {
            get
            {
                return _financialEvaluationCriterionField;
            }
            set
            {
                _financialEvaluationCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificTendererRequirement")]
        public TendererRequirementType[] SpecificTendererRequirement
        {
            get
            {
                return _specificTendererRequirementField;
            }
            set
            {
                _specificTendererRequirementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EconomicOperatorRole")]
        public EconomicOperatorRoleType[] EconomicOperatorRole
        {
            get
            {
                return _economicOperatorRoleField;
            }
            set
            {
                _economicOperatorRoleField = value;
            }
        }
    }
}