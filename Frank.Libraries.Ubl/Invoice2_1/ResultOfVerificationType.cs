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

        private ValidatorIdType _validatorIdField;

        private ValidationResultCodeType _validationResultCodeField;

        private ValidationDateType _validationDateField;

        private ValidationTimeType _validationTimeField;

        private ValidateProcessType _validateProcessField;

        private ValidateToolType _validateToolField;

        private ValidateToolVersionType _validateToolVersionField;

        private PartyType _signatoryPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidatorIdType ValidatorId
        {
            get
            {
                return _validatorIdField;
            }
            set
            {
                _validatorIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationResultCodeType ValidationResultCode
        {
            get
            {
                return _validationResultCodeField;
            }
            set
            {
                _validationResultCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationDateType ValidationDate
        {
            get
            {
                return _validationDateField;
            }
            set
            {
                _validationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationTimeType ValidationTime
        {
            get
            {
                return _validationTimeField;
            }
            set
            {
                _validationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateProcessType ValidateProcess
        {
            get
            {
                return _validateProcessField;
            }
            set
            {
                _validateProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateToolType ValidateTool
        {
            get
            {
                return _validateToolField;
            }
            set
            {
                _validateToolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateToolVersionType ValidateToolVersion
        {
            get
            {
                return _validateToolVersionField;
            }
            set
            {
                _validateToolVersionField = value;
            }
        }

        /// <remarks/>
        public PartyType SignatoryParty
        {
            get
            {
                return _signatoryPartyField;
            }
            set
            {
                _signatoryPartyField = value;
            }
        }
    }
}