namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("QuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class QuotationLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private QuantityType2 quantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TotalTaxAmountType totalTaxAmountField;

        private RequestForQuotationLineIDType requestForQuotationLineIDField;

        private DocumentReferenceType[] documentReferenceField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        private LineItemType[] alternativeLineItemField;

        private LineReferenceType requestLineReferenceField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return lineExtensionAmountField;
            }
            set
            {
                lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTaxAmountType TotalTaxAmount
        {
            get
            {
                return totalTaxAmountField;
            }
            set
            {
                totalTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestForQuotationLineIDType RequestForQuotationLineID
        {
            get
            {
                return requestForQuotationLineIDField;
            }
            set
            {
                requestForQuotationLineIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return documentReferenceField;
            }
            set
            {
                documentReferenceField = value;
            }
        }

        /// <remarks/>
        public LineItemType LineItem
        {
            get
            {
                return lineItemField;
            }
            set
            {
                lineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem")]
        public LineItemType[] SellerProposedSubstituteLineItem
        {
            get
            {
                return sellerProposedSubstituteLineItemField;
            }
            set
            {
                sellerProposedSubstituteLineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlternativeLineItem")]
        public LineItemType[] AlternativeLineItem
        {
            get
            {
                return alternativeLineItemField;
            }
            set
            {
                alternativeLineItemField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType RequestLineReference
        {
            get
            {
                return requestLineReferenceField;
            }
            set
            {
                requestLineReferenceField = value;
            }
        }
    }
}