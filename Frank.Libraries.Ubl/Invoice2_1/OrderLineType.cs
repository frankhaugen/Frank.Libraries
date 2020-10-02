namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class OrderLineType
    {

        private SubstitutionStatusCodeType substitutionStatusCodeField;

        private NoteType[] noteField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        private LineItemType[] sellerSubstitutedLineItemField;

        private LineItemType[] buyerProposedSubstituteLineItemField;

        private LineReferenceType catalogueLineReferenceField;

        private LineReferenceType quotationLineReferenceField;

        private OrderLineReferenceType[] orderLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubstitutionStatusCodeType SubstitutionStatusCode
        {
            get
            {
                return substitutionStatusCodeField;
            }
            set
            {
                substitutionStatusCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SellerSubstitutedLineItem")]
        public LineItemType[] SellerSubstitutedLineItem
        {
            get
            {
                return sellerSubstitutedLineItemField;
            }
            set
            {
                sellerSubstitutedLineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BuyerProposedSubstituteLineItem")]
        public LineItemType[] BuyerProposedSubstituteLineItem
        {
            get
            {
                return buyerProposedSubstituteLineItemField;
            }
            set
            {
                buyerProposedSubstituteLineItemField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType CatalogueLineReference
        {
            get
            {
                return catalogueLineReferenceField;
            }
            set
            {
                catalogueLineReferenceField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType QuotationLineReference
        {
            get
            {
                return quotationLineReferenceField;
            }
            set
            {
                quotationLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference
        {
            get
            {
                return orderLineReferenceField;
            }
            set
            {
                orderLineReferenceField = value;
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
    }
}