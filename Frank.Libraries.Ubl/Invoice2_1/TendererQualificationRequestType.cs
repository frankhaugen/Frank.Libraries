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

        private CompanyLegalFormCodeType companyLegalFormCodeField;

        private CompanyLegalFormType companyLegalFormField;

        private PersonalSituationType[] personalSituationField;

        private OperatingYearsQuantityType operatingYearsQuantityField;

        private EmployeeQuantityType employeeQuantityField;

        private DescriptionType[] descriptionField;

        private ClassificationSchemeType[] requiredBusinessClassificationSchemeField;

        private EvaluationCriterionType[] technicalEvaluationCriterionField;

        private EvaluationCriterionType[] financialEvaluationCriterionField;

        private TendererRequirementType[] specificTendererRequirementField;

        private EconomicOperatorRoleType[] economicOperatorRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormCodeType CompanyLegalFormCode
        {
            get
            {
                return companyLegalFormCodeField;
            }
            set
            {
                companyLegalFormCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormType CompanyLegalForm
        {
            get
            {
                return companyLegalFormField;
            }
            set
            {
                companyLegalFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PersonalSituationType[] PersonalSituation
        {
            get
            {
                return personalSituationField;
            }
            set
            {
                personalSituationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OperatingYearsQuantityType OperatingYearsQuantity
        {
            get
            {
                return operatingYearsQuantityField;
            }
            set
            {
                operatingYearsQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmployeeQuantityType EmployeeQuantity
        {
            get
            {
                return employeeQuantityField;
            }
            set
            {
                employeeQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("RequiredBusinessClassificationScheme")]
        public ClassificationSchemeType[] RequiredBusinessClassificationScheme
        {
            get
            {
                return requiredBusinessClassificationSchemeField;
            }
            set
            {
                requiredBusinessClassificationSchemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalEvaluationCriterion")]
        public EvaluationCriterionType[] TechnicalEvaluationCriterion
        {
            get
            {
                return technicalEvaluationCriterionField;
            }
            set
            {
                technicalEvaluationCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinancialEvaluationCriterion")]
        public EvaluationCriterionType[] FinancialEvaluationCriterion
        {
            get
            {
                return financialEvaluationCriterionField;
            }
            set
            {
                financialEvaluationCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificTendererRequirement")]
        public TendererRequirementType[] SpecificTendererRequirement
        {
            get
            {
                return specificTendererRequirementField;
            }
            set
            {
                specificTendererRequirementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EconomicOperatorRole")]
        public EconomicOperatorRoleType[] EconomicOperatorRole
        {
            get
            {
                return economicOperatorRoleField;
            }
            set
            {
                economicOperatorRoleField = value;
            }
        }
    }
}