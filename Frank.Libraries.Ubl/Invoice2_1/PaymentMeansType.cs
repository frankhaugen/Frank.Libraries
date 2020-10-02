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

        private IDType idField;

        private PaymentMeansCodeType paymentMeansCodeField;

        private PaymentDueDateType paymentDueDateField;

        private PaymentChannelCodeType paymentChannelCodeField;

        private InstructionIDType instructionIDField;

        private InstructionNoteType[] instructionNoteField;

        private PaymentIDType[] paymentIDField;

        private CardAccountType cardAccountField;

        private FinancialAccountType payerFinancialAccountField;

        private FinancialAccountType payeeFinancialAccountField;

        private CreditAccountType creditAccountField;

        private PaymentMandateType paymentMandateField;

        private TradeFinancingType tradeFinancingField;

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
        public PaymentMeansCodeType PaymentMeansCode
        {
            get
            {
                return paymentMeansCodeField;
            }
            set
            {
                paymentMeansCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDueDateType PaymentDueDate
        {
            get
            {
                return paymentDueDateField;
            }
            set
            {
                paymentDueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentChannelCodeType PaymentChannelCode
        {
            get
            {
                return paymentChannelCodeField;
            }
            set
            {
                paymentChannelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionIDType InstructionID
        {
            get
            {
                return instructionIDField;
            }
            set
            {
                instructionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InstructionNoteType[] InstructionNote
        {
            get
            {
                return instructionNoteField;
            }
            set
            {
                instructionNoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentIDType[] PaymentID
        {
            get
            {
                return paymentIDField;
            }
            set
            {
                paymentIDField = value;
            }
        }

        /// <remarks/>
        public CardAccountType CardAccount
        {
            get
            {
                return cardAccountField;
            }
            set
            {
                cardAccountField = value;
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
        public FinancialAccountType PayeeFinancialAccount
        {
            get
            {
                return payeeFinancialAccountField;
            }
            set
            {
                payeeFinancialAccountField = value;
            }
        }

        /// <remarks/>
        public CreditAccountType CreditAccount
        {
            get
            {
                return creditAccountField;
            }
            set
            {
                creditAccountField = value;
            }
        }

        /// <remarks/>
        public PaymentMandateType PaymentMandate
        {
            get
            {
                return paymentMandateField;
            }
            set
            {
                paymentMandateField = value;
            }
        }

        /// <remarks/>
        public TradeFinancingType TradeFinancing
        {
            get
            {
                return tradeFinancingField;
            }
            set
            {
                tradeFinancingField = value;
            }
        }
    }
}