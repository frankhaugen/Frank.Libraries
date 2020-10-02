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

        private DocumentReferenceType invoiceDocumentReferenceField;

        private DocumentReferenceType selfBilledInvoiceDocumentReferenceField;

        private DocumentReferenceType creditNoteDocumentReferenceField;

        private DocumentReferenceType selfBilledCreditNoteDocumentReferenceField;

        private DocumentReferenceType debitNoteDocumentReferenceField;

        private DocumentReferenceType reminderDocumentReferenceField;

        private DocumentReferenceType additionalDocumentReferenceField;

        private BillingReferenceLineType[] billingReferenceLineField;

        /// <remarks/>
        public DocumentReferenceType InvoiceDocumentReference
        {
            get
            {
                return invoiceDocumentReferenceField;
            }
            set
            {
                invoiceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType SelfBilledInvoiceDocumentReference
        {
            get
            {
                return selfBilledInvoiceDocumentReferenceField;
            }
            set
            {
                selfBilledInvoiceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CreditNoteDocumentReference
        {
            get
            {
                return creditNoteDocumentReferenceField;
            }
            set
            {
                creditNoteDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference
        {
            get
            {
                return selfBilledCreditNoteDocumentReferenceField;
            }
            set
            {
                selfBilledCreditNoteDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType DebitNoteDocumentReference
        {
            get
            {
                return debitNoteDocumentReferenceField;
            }
            set
            {
                debitNoteDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ReminderDocumentReference
        {
            get
            {
                return reminderDocumentReferenceField;
            }
            set
            {
                reminderDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType AdditionalDocumentReference
        {
            get
            {
                return additionalDocumentReferenceField;
            }
            set
            {
                additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReferenceLine")]
        public BillingReferenceLineType[] BillingReferenceLine
        {
            get
            {
                return billingReferenceLineField;
            }
            set
            {
                billingReferenceLineField = value;
            }
        }
    }
}