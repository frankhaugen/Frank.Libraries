namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PaymentMandateType
    {

        private IdType _idField;

        private MandateTypeCodeType _mandateTypeCodeField;

        private MaximumPaymentInstructionsNumericType _maximumPaymentInstructionsNumericField;

        private MaximumPaidAmountType _maximumPaidAmountField;

        private SignatureIdType _signatureIdField;

        private PartyType _payerPartyField;

        private FinancialAccountType _payerFinancialAccountField;

        private PeriodType _validityPeriodField;

        private PeriodType _paymentReversalPeriodField;

        private ClauseType[] _clauseField;

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
        public MandateTypeCodeType MandateTypeCode
        {
            get
            {
                return _mandateTypeCodeField;
            }
            set
            {
                _mandateTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaymentInstructionsNumericType MaximumPaymentInstructionsNumeric
        {
            get
            {
                return _maximumPaymentInstructionsNumericField;
            }
            set
            {
                _maximumPaymentInstructionsNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaidAmountType MaximumPaidAmount
        {
            get
            {
                return _maximumPaidAmountField;
            }
            set
            {
                _maximumPaidAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SignatureIdType SignatureId
        {
            get
            {
                return _signatureIdField;
            }
            set
            {
                _signatureIdField = value;
            }
        }

        /// <remarks/>
        public PartyType PayerParty
        {
            get
            {
                return _payerPartyField;
            }
            set
            {
                _payerPartyField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType PayerFinancialAccount
        {
            get
            {
                return _payerFinancialAccountField;
            }
            set
            {
                _payerFinancialAccountField = value;
            }
        }

        /// <remarks/>
        public PeriodType ValidityPeriod
        {
            get
            {
                return _validityPeriodField;
            }
            set
            {
                _validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PaymentReversalPeriod
        {
            get
            {
                return _paymentReversalPeriodField;
            }
            set
            {
                _paymentReversalPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clause")]
        public ClauseType[] Clause
        {
            get
            {
                return _clauseField;
            }
            set
            {
                _clauseField = value;
            }
        }
    }
}