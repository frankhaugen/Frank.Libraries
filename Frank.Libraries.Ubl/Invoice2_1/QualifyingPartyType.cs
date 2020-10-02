namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalQualifyingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class QualifyingPartyType
    {

        private ParticipationPercentType _participationPercentField;

        private PersonalSituationType[] _personalSituationField;

        private OperatingYearsQuantityType _operatingYearsQuantityField;

        private EmployeeQuantityType _employeeQuantityField;

        private BusinessClassificationEvidenceIdType _businessClassificationEvidenceIdField;

        private BusinessIdentityEvidenceIdType _businessIdentityEvidenceIdField;

        private TendererRoleCodeType _tendererRoleCodeField;

        private ClassificationSchemeType _businessClassificationSchemeField;

        private CapabilityType[] _technicalCapabilityField;

        private CapabilityType[] _financialCapabilityField;

        private CompletedTaskType[] _completedTaskField;

        private DeclarationType[] _declarationField;

        private PartyType _partyField;

        private EconomicOperatorRoleType _economicOperatorRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ParticipationPercentType ParticipationPercent
        {
            get
            {
                return _participationPercentField;
            }
            set
            {
                _participationPercentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BusinessClassificationEvidenceIdType BusinessClassificationEvidenceId
        {
            get
            {
                return _businessClassificationEvidenceIdField;
            }
            set
            {
                _businessClassificationEvidenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BusinessIdentityEvidenceIdType BusinessIdentityEvidenceId
        {
            get
            {
                return _businessIdentityEvidenceIdField;
            }
            set
            {
                _businessIdentityEvidenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TendererRoleCodeType TendererRoleCode
        {
            get
            {
                return _tendererRoleCodeField;
            }
            set
            {
                _tendererRoleCodeField = value;
            }
        }

        /// <remarks/>
        public ClassificationSchemeType BusinessClassificationScheme
        {
            get
            {
                return _businessClassificationSchemeField;
            }
            set
            {
                _businessClassificationSchemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCapability")]
        public CapabilityType[] TechnicalCapability
        {
            get
            {
                return _technicalCapabilityField;
            }
            set
            {
                _technicalCapabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinancialCapability")]
        public CapabilityType[] FinancialCapability
        {
            get
            {
                return _financialCapabilityField;
            }
            set
            {
                _financialCapabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompletedTask")]
        public CompletedTaskType[] CompletedTask
        {
            get
            {
                return _completedTaskField;
            }
            set
            {
                _completedTaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Declaration")]
        public DeclarationType[] Declaration
        {
            get
            {
                return _declarationField;
            }
            set
            {
                _declarationField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return _partyField;
            }
            set
            {
                _partyField = value;
            }
        }

        /// <remarks/>
        public EconomicOperatorRoleType EconomicOperatorRole
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