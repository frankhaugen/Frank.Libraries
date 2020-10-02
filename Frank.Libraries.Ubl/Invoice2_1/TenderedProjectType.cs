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

        private VariantIdType _variantIdField;

        private FeeAmountType _feeAmountField;

        private FeeDescriptionType[] _feeDescriptionField;

        private TenderEnvelopeIdType _tenderEnvelopeIdField;

        private TenderEnvelopeTypeCodeType _tenderEnvelopeTypeCodeField;

        private ProcurementProjectLotType _procurementProjectLotField;

        private DocumentReferenceType[] _evidenceDocumentReferenceField;

        private TaxTotalType[] _taxTotalField;

        private MonetaryTotalType _legalMonetaryTotalField;

        private TenderLineType[] _tenderLineField;

        private AwardingCriterionResponseType[] _awardingCriterionResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VariantIdType VariantId
        {
            get
            {
                return _variantIdField;
            }
            set
            {
                _variantIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeAmountType FeeAmount
        {
            get
            {
                return _feeAmountField;
            }
            set
            {
                _feeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeDescriptionType[] FeeDescription
        {
            get
            {
                return _feeDescriptionField;
            }
            set
            {
                _feeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderEnvelopeIdType TenderEnvelopeId
        {
            get
            {
                return _tenderEnvelopeIdField;
            }
            set
            {
                _tenderEnvelopeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode
        {
            get
            {
                return _tenderEnvelopeTypeCodeField;
            }
            set
            {
                _tenderEnvelopeTypeCodeField = value;
            }
        }

        /// <remarks/>
        public ProcurementProjectLotType ProcurementProjectLot
        {
            get
            {
                return _procurementProjectLotField;
            }
            set
            {
                _procurementProjectLotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvidenceDocumentReference")]
        public DocumentReferenceType[] EvidenceDocumentReference
        {
            get
            {
                return _evidenceDocumentReferenceField;
            }
            set
            {
                _evidenceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return _taxTotalField;
            }
            set
            {
                _taxTotalField = value;
            }
        }

        /// <remarks/>
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return _legalMonetaryTotalField;
            }
            set
            {
                _legalMonetaryTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderLine")]
        public TenderLineType[] TenderLine
        {
            get
            {
                return _tenderLineField;
            }
            set
            {
                _tenderLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionResponse")]
        public AwardingCriterionResponseType[] AwardingCriterionResponse
        {
            get
            {
                return _awardingCriterionResponseField;
            }
            set
            {
                _awardingCriterionResponseField = value;
            }
        }
    }
}