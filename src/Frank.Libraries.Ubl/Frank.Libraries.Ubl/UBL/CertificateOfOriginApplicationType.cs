using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("CertificateOfOriginApplication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CertificateOfOriginApplicationType
{
    private ApplicationStatusCodeType applicationStatusCodeField;

    private CertificateTypeType certificateTypeField;

    private DocumentDistributionType[] documentDistributionField;

    private EndorserPartyType[] endorserPartyField;

    private PartyType exporterPartyField;

    private PartyType importerPartyField;

    private PartyType issuerPartyField;

    private CountryType issuingCountryField;

    private OriginalJobIDType originalJobIDField;

    private PartyType preparationPartyField;

    private PreviousJobIDType previousJobIDField;

    private ReferenceIDType referenceIDField;

    private RemarksType[] remarksField;

    private ShipmentType shipmentField;

    private SignatureType[] signatureField;

    private DocumentReferenceType[] supportingDocumentReferenceField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceIDType ReferenceID
    {
        get => referenceIDField;
        set => referenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeType CertificateType
    {
        get => certificateTypeField;
        set => certificateTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ApplicationStatusCodeType ApplicationStatusCode
    {
        get => applicationStatusCodeField;
        set => applicationStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OriginalJobIDType OriginalJobID
    {
        get => originalJobIDField;
        set => originalJobIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreviousJobIDType PreviousJobID
    {
        get => previousJobIDField;
        set => previousJobIDField = value;
    }

    /// <remarks />
    [XmlElement("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks
    {
        get => remarksField;
        set => remarksField = value;
    }

    /// <remarks />
    public ShipmentType Shipment
    {
        get => shipmentField;
        set => shipmentField = value;
    }

    /// <remarks />
    [XmlElement("EndorserParty")]
    public EndorserPartyType[] EndorserParty
    {
        get => endorserPartyField;
        set => endorserPartyField = value;
    }

    /// <remarks />
    public PartyType PreparationParty
    {
        get => preparationPartyField;
        set => preparationPartyField = value;
    }

    /// <remarks />
    public PartyType IssuerParty
    {
        get => issuerPartyField;
        set => issuerPartyField = value;
    }

    /// <remarks />
    public PartyType ExporterParty
    {
        get => exporterPartyField;
        set => exporterPartyField = value;
    }

    /// <remarks />
    public PartyType ImporterParty
    {
        get => importerPartyField;
        set => importerPartyField = value;
    }

    /// <remarks />
    public CountryType IssuingCountry
    {
        get => issuingCountryField;
        set => issuingCountryField = value;
    }

    /// <remarks />
    [XmlElement("DocumentDistribution")]
    public DocumentDistributionType[] DocumentDistribution
    {
        get => documentDistributionField;
        set => documentDistributionField = value;
    }

    /// <remarks />
    [XmlElement("SupportingDocumentReference")]
    public DocumentReferenceType[] SupportingDocumentReference
    {
        get => supportingDocumentReferenceField;
        set => supportingDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Signature")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }
}