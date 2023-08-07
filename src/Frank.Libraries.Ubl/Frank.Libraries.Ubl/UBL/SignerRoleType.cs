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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class SignerRoleType
{
    private EncapsulatedPKIDataType[] certifiedRolesField;

    private AnyType[] claimedRolesField;

    /// <remarks />
    [XmlArrayItem("ClaimedRole", IsNullable = false)]
    public AnyType[] ClaimedRoles
    {
        get => claimedRolesField;
        set => claimedRolesField = value;
    }

    /// <remarks />
    [XmlArrayItem("CertifiedRole", IsNullable = false)]
    public EncapsulatedPKIDataType[] CertifiedRoles
    {
        get => certifiedRolesField;
        set => certifiedRolesField = value;
    }
}