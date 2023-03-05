using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("Certificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CertificateType
{
    private CertificateTypeType certificateType1Field;

    private CertificateTypeCodeType certificateTypeCodeField;

    private DocumentReferenceType[] documentReferenceField;

    private IDType idField;

    private PartyType issuerPartyField;

    private RemarksType[] remarksField;

    private SignatureType[] signatureField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeCodeType CertificateTypeCode
    {
        get => certificateTypeCodeField;
        set => certificateTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("CertificateType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CertificateTypeType CertificateType1
    {
        get => certificateType1Field;
        set => certificateType1Field = value;
    }

    /// <remarks />
    [XmlElement("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks
    {
        get => remarksField;
        set => remarksField = value;
    }

    /// <remarks />
    public PartyType IssuerParty
    {
        get => issuerPartyField;
        set => issuerPartyField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Signature")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }
}