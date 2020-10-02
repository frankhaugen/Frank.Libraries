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

        private IDType idField;

        private MandateTypeCodeType mandateTypeCodeField;

        private MaximumPaymentInstructionsNumericType maximumPaymentInstructionsNumericField;

        private MaximumPaidAmountType maximumPaidAmountField;

        private SignatureIDType signatureIDField;

        private PartyType payerPartyField;

        private FinancialAccountType payerFinancialAccountField;

        private PeriodType validityPeriodField;

        private PeriodType paymentReversalPeriodField;

        private ClauseType[] clauseField;

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
        public MandateTypeCodeType MandateTypeCode
        {
            get
            {
                return mandateTypeCodeField;
            }
            set
            {
                mandateTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaymentInstructionsNumericType MaximumPaymentInstructionsNumeric
        {
            get
            {
                return maximumPaymentInstructionsNumericField;
            }
            set
            {
                maximumPaymentInstructionsNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaidAmountType MaximumPaidAmount
        {
            get
            {
                return maximumPaidAmountField;
            }
            set
            {
                maximumPaidAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SignatureIDType SignatureID
        {
            get
            {
                return signatureIDField;
            }
            set
            {
                signatureIDField = value;
            }
        }

        /// <remarks/>
        public PartyType PayerParty
        {
            get
            {
                return payerPartyField;
            }
            set
            {
                payerPartyField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType PayerFinancialAccount
        {
            get
            {
                return payerFinancialAccountField;
            }
            set
            {
                payerFinancialAccountField = value;
            }
        }

        /// <remarks/>
        public PeriodType ValidityPeriod
        {
            get
            {
                return validityPeriodField;
            }
            set
            {
                validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PaymentReversalPeriod
        {
            get
            {
                return paymentReversalPeriodField;
            }
            set
            {
                paymentReversalPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clause")]
        public ClauseType[] Clause
        {
            get
            {
                return clauseField;
            }
            set
            {
                clauseField = value;
            }
        }
    }
}