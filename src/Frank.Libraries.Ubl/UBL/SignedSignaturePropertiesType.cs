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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class SignedSignaturePropertiesType
{
    private string idField;

    private SignaturePolicyIdentifierType signaturePolicyIdentifierField;

    private SignatureProductionPlaceType signatureProductionPlaceField;

    private SignerRoleType signerRoleField;

    private CertIDType[] signingCertificateField;

    private DateTime signingTimeField;

    private bool signingTimeFieldSpecified;

    /// <remarks />
    public DateTime SigningTime
    {
        get => signingTimeField;
        set => signingTimeField = value;
    }

    /// <remarks />
    [XmlIgnore]
    public bool SigningTimeSpecified
    {
        get => signingTimeFieldSpecified;
        set => signingTimeFieldSpecified = value;
    }

    /// <remarks />
    [XmlArrayItem("Cert", IsNullable = false)]
    public CertIDType[] SigningCertificate
    {
        get => signingCertificateField;
        set => signingCertificateField = value;
    }

    /// <remarks />
    public SignaturePolicyIdentifierType SignaturePolicyIdentifier
    {
        get => signaturePolicyIdentifierField;
        set => signaturePolicyIdentifierField = value;
    }

    /// <remarks />
    public SignatureProductionPlaceType SignatureProductionPlace
    {
        get => signatureProductionPlaceField;
        set => signatureProductionPlaceField = value;
    }

    /// <remarks />
    public SignerRoleType SignerRole
    {
        get => signerRoleField;
        set => signerRoleField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}