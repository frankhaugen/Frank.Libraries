namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Certificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class CertificateType
{

    private IDType idField;

    private CertificateTypeCodeType certificateTypeCodeField;

    private CertificateTypeType certificateType1Field;

    private RemarksType[] remarksField;

    private PartyType issuerPartyField;

    private DocumentReferenceType[] documentReferenceField;

    private SignatureType[] signatureField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeCodeType CertificateTypeCode
    {
        get
        {
            return this.certificateTypeCodeField;
        }
        set
        {
            this.certificateTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CertificateType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeType CertificateType1
    {
        get
        {
            return this.certificateType1Field;
        }
        set
        {
            this.certificateType1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks
    {
        get
        {
            return this.remarksField;
        }
        set
        {
            this.remarksField = value;
        }
    }

    /// <remarks/>
    public PartyType IssuerParty
    {
        get
        {
            return this.issuerPartyField;
        }
        set
        {
            this.issuerPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get
        {
            return this.documentReferenceField;
        }
        set
        {
            this.documentReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature")]
    public SignatureType[] Signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }
}