namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class BillingReferenceType
    {

        private DocumentReferenceType _invoiceDocumentReferenceField;

        private DocumentReferenceType _selfBilledInvoiceDocumentReferenceField;

        private DocumentReferenceType _creditNoteDocumentReferenceField;

        private DocumentReferenceType _selfBilledCreditNoteDocumentReferenceField;

        private DocumentReferenceType _debitNoteDocumentReferenceField;

        private DocumentReferenceType _reminderDocumentReferenceField;

        private DocumentReferenceType _additionalDocumentReferenceField;

        private BillingReferenceLineType[] _billingReferenceLineField;

        /// <remarks/>
        public DocumentReferenceType InvoiceDocumentReference
        {
            get
            {
                return _invoiceDocumentReferenceField;
            }
            set
            {
                _invoiceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType SelfBilledInvoiceDocumentReference
        {
            get
            {
                return _selfBilledInvoiceDocumentReferenceField;
            }
            set
            {
                _selfBilledInvoiceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CreditNoteDocumentReference
        {
            get
            {
                return _creditNoteDocumentReferenceField;
            }
            set
            {
                _creditNoteDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference
        {
            get
            {
                return _selfBilledCreditNoteDocumentReferenceField;
            }
            set
            {
                _selfBilledCreditNoteDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType DebitNoteDocumentReference
        {
            get
            {
                return _debitNoteDocumentReferenceField;
            }
            set
            {
                _debitNoteDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ReminderDocumentReference
        {
            get
            {
                return _reminderDocumentReferenceField;
            }
            set
            {
                _reminderDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType AdditionalDocumentReference
        {
            get
            {
                return _additionalDocumentReferenceField;
            }
            set
            {
                _additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReferenceLine")]
        public BillingReferenceLineType[] BillingReferenceLine
        {
            get
            {
                return _billingReferenceLineField;
            }
            set
            {
                _billingReferenceLineField = value;
            }
        }
    }
}