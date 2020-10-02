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

        private IDType idField;

        private TenderingTermsType tenderingTermsField;

        private ProcurementProjectType procurementProjectField;

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
        public TenderingTermsType TenderingTerms
        {
            get
            {
                return tenderingTermsField;
            }
            set
            {
                tenderingTermsField = value;
            }
        }

        /// <remarks/>
        public ProcurementProjectType ProcurementProject
        {
            get
            {
                return procurementProjectField;
            }
            set
            {
                procurementProjectField = value;
            }
        }
    }
}