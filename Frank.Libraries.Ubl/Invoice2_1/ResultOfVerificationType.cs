namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ResultOfVerification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ResultOfVerificationType
    {

        private ValidatorIDType validatorIDField;

        private ValidationResultCodeType validationResultCodeField;

        private ValidationDateType validationDateField;

        private ValidationTimeType validationTimeField;

        private ValidateProcessType validateProcessField;

        private ValidateToolType validateToolField;

        private ValidateToolVersionType validateToolVersionField;

        private PartyType signatoryPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidatorIDType ValidatorID
        {
            get
            {
                return validatorIDField;
            }
            set
            {
                validatorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationResultCodeType ValidationResultCode
        {
            get
            {
                return validationResultCodeField;
            }
            set
            {
                validationResultCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationDateType ValidationDate
        {
            get
            {
                return validationDateField;
            }
            set
            {
                validationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationTimeType ValidationTime
        {
            get
            {
                return validationTimeField;
            }
            set
            {
                validationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateProcessType ValidateProcess
        {
            get
            {
                return validateProcessField;
            }
            set
            {
                validateProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateToolType ValidateTool
        {
            get
            {
                return validateToolField;
            }
            set
            {
                validateToolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateToolVersionType ValidateToolVersion
        {
            get
            {
                return validateToolVersionField;
            }
            set
            {
                validateToolVersionField = value;
            }
        }

        /// <remarks/>
        public PartyType SignatoryParty
        {
            get
            {
                return signatoryPartyField;
            }
            set
            {
                signatoryPartyField = value;
            }
        }
    }
}