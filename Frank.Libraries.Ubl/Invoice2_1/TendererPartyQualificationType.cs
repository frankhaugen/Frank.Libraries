namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TendererPartyQualification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TendererPartyQualificationType
    {

        private ProcurementProjectLotType[] _interestedProcurementProjectLotField;

        private QualifyingPartyType _mainQualifyingPartyField;

        private QualifyingPartyType[] _additionalQualifyingPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterestedProcurementProjectLot")]
        public ProcurementProjectLotType[] InterestedProcurementProjectLot
        {
            get
            {
                return _interestedProcurementProjectLotField;
            }
            set
            {
                _interestedProcurementProjectLotField = value;
            }
        }

        /// <remarks/>
        public QualifyingPartyType MainQualifyingParty
        {
            get
            {
                return _mainQualifyingPartyField;
            }
            set
            {
                _mainQualifyingPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty")]
        public QualifyingPartyType[] AdditionalQualifyingParty
        {
            get
            {
                return _additionalQualifyingPartyField;
            }
            set
            {
                _additionalQualifyingPartyField = value;
            }
        }
    }
}