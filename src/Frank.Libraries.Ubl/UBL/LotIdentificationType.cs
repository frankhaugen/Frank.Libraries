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
[XmlRoot("LotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class LotIdentificationType
{
    private ItemPropertyType[] additionalItemPropertyField;

    private ExpiryDateType expiryDateField;

    private LotNumberIDType lotNumberIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LotNumberIDType LotNumberID
    {
        get => lotNumberIDField;
        set => lotNumberIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpiryDateType ExpiryDate
    {
        get => expiryDateField;
        set => expiryDateField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalItemProperty")]
    public ItemPropertyType[] AdditionalItemProperty
    {
        get => additionalItemPropertyField;
        set => additionalItemPropertyField = value;
    }
}