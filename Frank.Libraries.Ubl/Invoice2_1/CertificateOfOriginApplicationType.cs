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

        private ReferenceIDType referenceIDField;

        private CertificateTypeType certificateTypeField;

        private ApplicationStatusCodeType applicationStatusCodeField;

        private OriginalJobIDType originalJobIDField;

        private PreviousJobIDType previousJobIDField;

        private RemarksType[] remarksField;

        private ShipmentType shipmentField;

        private EndorserPartyType[] endorserPartyField;

        private PartyType preparationPartyField;

        private PartyType issuerPartyField;

        private PartyType exporterPartyField;

        private PartyType importerPartyField;

        private CountryType issuingCountryField;

        private DocumentDistributionType[] documentDistributionField;

        private DocumentReferenceType[] supportingDocumentReferenceField;

        private SignatureType[] signatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceIDType ReferenceID
        {
            get
            {
                return referenceIDField;
            }
            set
            {
                referenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CertificateTypeType CertificateType
        {
            get
            {
                return certificateTypeField;
            }
            set
            {
                certificateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ApplicationStatusCodeType ApplicationStatusCode
        {
            get
            {
                return applicationStatusCodeField;
            }
            set
            {
                applicationStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OriginalJobIDType OriginalJobID
        {
            get
            {
                return originalJobIDField;
            }
            set
            {
                originalJobIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousJobIDType PreviousJobID
        {
            get
            {
                return previousJobIDField;
            }
            set
            {
                previousJobIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return remarksField;
            }
            set
            {
                remarksField = value;
            }
        }

        /// <remarks/>
        public ShipmentType Shipment
        {
            get
            {
                return shipmentField;
            }
            set
            {
                shipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndorserParty")]
        public EndorserPartyType[] EndorserParty
        {
            get
            {
                return endorserPartyField;
            }
            set
            {
                endorserPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType PreparationParty
        {
            get
            {
                return preparationPartyField;
            }
            set
            {
                preparationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType IssuerParty
        {
            get
            {
                return issuerPartyField;
            }
            set
            {
                issuerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ExporterParty
        {
            get
            {
                return exporterPartyField;
            }
            set
            {
                exporterPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ImporterParty
        {
            get
            {
                return importerPartyField;
            }
            set
            {
                importerPartyField = value;
            }
        }

        /// <remarks/>
        public CountryType IssuingCountry
        {
            get
            {
                return issuingCountryField;
            }
            set
            {
                issuingCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution")]
        public DocumentDistributionType[] DocumentDistribution
        {
            get
            {
                return documentDistributionField;
            }
            set
            {
                documentDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference")]
        public DocumentReferenceType[] SupportingDocumentReference
        {
            get
            {
                return supportingDocumentReferenceField;
            }
            set
            {
                supportingDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature")]
        public SignatureType[] Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }
    }
}