namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TenderPreparation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderPreparationType
    {

        private TenderEnvelopeIdType _tenderEnvelopeIdField;

        private TenderEnvelopeTypeCodeType _tenderEnvelopeTypeCodeField;

        private DescriptionType[] _descriptionField;

        private OpenTenderIdType _openTenderIdField;

        private ProcurementProjectLotType[] _procurementProjectLotField;

        private TenderRequirementType[] _documentTenderRequirementField;

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
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OpenTenderIdType OpenTenderId
        {
            get
            {
                return _openTenderIdField;
            }
            set
            {
                _openTenderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot")]
        public ProcurementProjectLotType[] ProcurementProjectLot
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentTenderRequirement")]
        public TenderRequirementType[] DocumentTenderRequirement
        {
            get
            {
                return _documentTenderRequirementField;
            }
            set
            {
                _documentTenderRequirementField = value;
            }
        }
    }
}