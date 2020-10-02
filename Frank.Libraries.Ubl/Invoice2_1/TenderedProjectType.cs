namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AwardedTenderedProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderedProjectType
    {

        private VariantIDType variantIDField;

        private FeeAmountType feeAmountField;

        private FeeDescriptionType[] feeDescriptionField;

        private TenderEnvelopeIDType tenderEnvelopeIDField;

        private TenderEnvelopeTypeCodeType tenderEnvelopeTypeCodeField;

        private ProcurementProjectLotType procurementProjectLotField;

        private DocumentReferenceType[] evidenceDocumentReferenceField;

        private TaxTotalType[] taxTotalField;

        private MonetaryTotalType legalMonetaryTotalField;

        private TenderLineType[] tenderLineField;

        private AwardingCriterionResponseType[] awardingCriterionResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VariantIDType VariantID
        {
            get
            {
                return variantIDField;
            }
            set
            {
                variantIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeAmountType FeeAmount
        {
            get
            {
                return feeAmountField;
            }
            set
            {
                feeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeDescriptionType[] FeeDescription
        {
            get
            {
                return feeDescriptionField;
            }
            set
            {
                feeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderEnvelopeIDType TenderEnvelopeID
        {
            get
            {
                return tenderEnvelopeIDField;
            }
            set
            {
                tenderEnvelopeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode
        {
            get
            {
                return tenderEnvelopeTypeCodeField;
            }
            set
            {
                tenderEnvelopeTypeCodeField = value;
            }
        }

        /// <remarks/>
        public ProcurementProjectLotType ProcurementProjectLot
        {
            get
            {
                return procurementProjectLotField;
            }
            set
            {
                procurementProjectLotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvidenceDocumentReference")]
        public DocumentReferenceType[] EvidenceDocumentReference
        {
            get
            {
                return evidenceDocumentReferenceField;
            }
            set
            {
                evidenceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return taxTotalField;
            }
            set
            {
                taxTotalField = value;
            }
        }

        /// <remarks/>
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return legalMonetaryTotalField;
            }
            set
            {
                legalMonetaryTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderLine")]
        public TenderLineType[] TenderLine
        {
            get
            {
                return tenderLineField;
            }
            set
            {
                tenderLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionResponse")]
        public AwardingCriterionResponseType[] AwardingCriterionResponse
        {
            get
            {
                return awardingCriterionResponseField;
            }
            set
            {
                awardingCriterionResponseField = value;
            }
        }
    }
}