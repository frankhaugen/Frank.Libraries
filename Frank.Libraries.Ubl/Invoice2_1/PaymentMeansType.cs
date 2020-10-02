namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PaymentMeansType
    {

        private IdType _idField;

        private PaymentMeansCodeType _paymentMeansCodeField;

        private PaymentDueDateType _paymentDueDateField;

        private PaymentChannelCodeType _paymentChannelCodeField;

        private InstructionIdType _instructionIdField;

        private InstructionNoteType[] _instructionNoteField;

        private PaymentIdType[] _paymentIdField;

        private CardAccountType _cardAccountField;

        private FinancialAccountType _payerFinancialAccountField;

        private FinancialAccountType _payeeFinancialAccountField;

        private CreditAccountType _creditAccountField;

        private PaymentMandateType _paymentMandateField;

        private TradeFinancingType _tradeFinancingField;

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
        public PaymentMeansCodeType PaymentMeansCode
        {
            get
            {
                return _paymentMeansCodeField;
            }
            set
            {
                _paymentMeansCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDueDateType PaymentDueDate
        {
            get
            {
                return _paymentDueDateField;
            }
            set
            {
                _paymentDueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentChannelCodeType PaymentChannelCode
        {
            get
            {
                return _paymentChannelCodeField;
            }
            set
            {
                _paymentChannelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionIdType InstructionId
        {
            get
            {
                return _instructionIdField;
            }
            set
            {
                _instructionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionNoteType[] InstructionNote
        {
            get
            {
                return _instructionNoteField;
            }
            set
            {
                _instructionNoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentIdType[] PaymentId
        {
            get
            {
                return _paymentIdField;
            }
            set
            {
                _paymentIdField = value;
            }
        }

        /// <remarks/>
        public CardAccountType CardAccount
        {
            get
            {
                return _cardAccountField;
            }
            set
            {
                _cardAccountField = value;
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
        public FinancialAccountType PayeeFinancialAccount
        {
            get
            {
                return _payeeFinancialAccountField;
            }
            set
            {
                _payeeFinancialAccountField = value;
            }
        }

        /// <remarks/>
        public CreditAccountType CreditAccount
        {
            get
            {
                return _creditAccountField;
            }
            set
            {
                _creditAccountField = value;
            }
        }

        /// <remarks/>
        public PaymentMandateType PaymentMandate
        {
            get
            {
                return _paymentMandateField;
            }
            set
            {
                _paymentMandateField = value;
            }
        }

        /// <remarks/>
        public TradeFinancingType TradeFinancing
        {
            get
            {
                return _tradeFinancingField;
            }
            set
            {
                _tradeFinancingField = value;
            }
        }
    }
}