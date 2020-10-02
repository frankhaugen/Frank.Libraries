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

        private ParticipationPercentType participationPercentField;

        private PersonalSituationType[] personalSituationField;

        private OperatingYearsQuantityType operatingYearsQuantityField;

        private EmployeeQuantityType employeeQuantityField;

        private BusinessClassificationEvidenceIDType businessClassificationEvidenceIDField;

        private BusinessIdentityEvidenceIDType businessIdentityEvidenceIDField;

        private TendererRoleCodeType tendererRoleCodeField;

        private ClassificationSchemeType businessClassificationSchemeField;

        private CapabilityType[] technicalCapabilityField;

        private CapabilityType[] financialCapabilityField;

        private CompletedTaskType[] completedTaskField;

        private DeclarationType[] declarationField;

        private PartyType partyField;

        private EconomicOperatorRoleType economicOperatorRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ParticipationPercentType ParticipationPercent
        {
            get
            {
                return participationPercentField;
            }
            set
            {
                participationPercentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BusinessClassificationEvidenceIDType BusinessClassificationEvidenceID
        {
            get
            {
                return businessClassificationEvidenceIDField;
            }
            set
            {
                businessClassificationEvidenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BusinessIdentityEvidenceIDType BusinessIdentityEvidenceID
        {
            get
            {
                return businessIdentityEvidenceIDField;
            }
            set
            {
                businessIdentityEvidenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TendererRoleCodeType TendererRoleCode
        {
            get
            {
                return tendererRoleCodeField;
            }
            set
            {
                tendererRoleCodeField = value;
            }
        }

        /// <remarks/>
        public ClassificationSchemeType BusinessClassificationScheme
        {
            get
            {
                return businessClassificationSchemeField;
            }
            set
            {
                businessClassificationSchemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCapability")]
        public CapabilityType[] TechnicalCapability
        {
            get
            {
                return technicalCapabilityField;
            }
            set
            {
                technicalCapabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinancialCapability")]
        public CapabilityType[] FinancialCapability
        {
            get
            {
                return financialCapabilityField;
            }
            set
            {
                financialCapabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompletedTask")]
        public CompletedTaskType[] CompletedTask
        {
            get
            {
                return completedTaskField;
            }
            set
            {
                completedTaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Declaration")]
        public DeclarationType[] Declaration
        {
            get
            {
                return declarationField;
            }
            set
            {
                declarationField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return partyField;
            }
            set
            {
                partyField = value;
            }
        }

        /// <remarks/>
        public EconomicOperatorRoleType EconomicOperatorRole
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