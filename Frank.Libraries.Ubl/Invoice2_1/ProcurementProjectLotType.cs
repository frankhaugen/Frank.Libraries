namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("InterestedProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ProcurementProjectLotType
    {

        private IdType _idField;

        private TenderingTermsType _tenderingTermsField;

        private ProcurementProjectType _procurementProjectField;

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
        public TenderingTermsType TenderingTerms
        {
            get
            {
                return _tenderingTermsField;
            }
            set
            {
                _tenderingTermsField = value;
            }
        }

        /// <remarks/>
        public ProcurementProjectType ProcurementProject
        {
            get
            {
                return _procurementProjectField;
            }
            set
            {
                _procurementProjectField = value;
            }
        }
    }
}