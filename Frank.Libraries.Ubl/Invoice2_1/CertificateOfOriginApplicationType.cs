namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CertificateOfOriginApplication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CertificateOfOriginApplicationType
    {

        private ReferenceIdType _referenceIdField;

        private CertificateTypeType _certificateTypeField;

        private ApplicationStatusCodeType _applicationStatusCodeField;

        private OriginalJobIdType _originalJobIdField;

        private PreviousJobIdType _previousJobIdField;

        private RemarksType[] _remarksField;

        private ShipmentType _shipmentField;

        private EndorserPartyType[] _endorserPartyField;

        private PartyType _preparationPartyField;

        private PartyType _issuerPartyField;

        private PartyType _exporterPartyField;

        private PartyType _importerPartyField;

        private CountryType _issuingCountryField;

        private DocumentDistributionType[] _documentDistributionField;

        private DocumentReferenceType[] _supportingDocumentReferenceField;

        private SignatureType[] _signatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceIdType ReferenceId
        {
            get
            {
                return _referenceIdField;
            }
            set
            {
                _referenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CertificateTypeType CertificateType
        {
            get
            {
                return _certificateTypeField;
            }
            set
            {
                _certificateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ApplicationStatusCodeType ApplicationStatusCode
        {
            get
            {
                return _applicationStatusCodeField;
            }
            set
            {
                _applicationStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OriginalJobIdType OriginalJobId
        {
            get
            {
                return _originalJobIdField;
            }
            set
            {
                _originalJobIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousJobIdType PreviousJobId
        {
            get
            {
                return _previousJobIdField;
            }
            set
            {
                _previousJobIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return _remarksField;
            }
            set
            {
                _remarksField = value;
            }
        }

        /// <remarks/>
        public ShipmentType Shipment
        {
            get
            {
                return _shipmentField;
            }
            set
            {
                _shipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndorserParty")]
        public EndorserPartyType[] EndorserParty
        {
            get
            {
                return _endorserPartyField;
            }
            set
            {
                _endorserPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType PreparationParty
        {
            get
            {
                return _preparationPartyField;
            }
            set
            {
                _preparationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType IssuerParty
        {
            get
            {
                return _issuerPartyField;
            }
            set
            {
                _issuerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ExporterParty
        {
            get
            {
                return _exporterPartyField;
            }
            set
            {
                _exporterPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ImporterParty
        {
            get
            {
                return _importerPartyField;
            }
            set
            {
                _importerPartyField = value;
            }
        }

        /// <remarks/>
        public CountryType IssuingCountry
        {
            get
            {
                return _issuingCountryField;
            }
            set
            {
                _issuingCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution")]
        public DocumentDistributionType[] DocumentDistribution
        {
            get
            {
                return _documentDistributionField;
            }
            set
            {
                _documentDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference")]
        public DocumentReferenceType[] SupportingDocumentReference
        {
            get
            {
                return _supportingDocumentReferenceField;
            }
            set
            {
                _supportingDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature")]
        public SignatureType[] Signature
        {
            get
            {
                return _signatureField;
            }
            set
            {
                _signatureField = value;
            }
        }
    }
}