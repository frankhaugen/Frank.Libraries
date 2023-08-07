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
[XmlRoot("CategorizesClassificationCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ClassificationCategoryType
{
    private ClassificationCategoryType[] categorizesClassificationCategoryField;

    private CodeValueType codeValueField;

    private DescriptionType[] descriptionField;

    private NameType1 nameField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CodeValueType CodeValue
    {
        get => codeValueField;
        set => codeValueField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("CategorizesClassificationCategory")]
    public ClassificationCategoryType[] CategorizesClassificationCategory
    {
        get => categorizesClassificationCategoryField;
        set => categorizesClassificationCategoryField = value;
    }
}