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
[XmlRoot("CatalogueRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class CatalogueRequestLineType
{
    private ContractSubdivisionType contractSubdivisionField;

    private IDType idField;

    private ItemType itemField;

    private PeriodType lineValidityPeriodField;

    private NoteType[] noteField;

    private ItemLocationQuantityType[] requiredItemLocationQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractSubdivisionType ContractSubdivision
    {
        get => contractSubdivisionField;
        set => contractSubdivisionField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    public PeriodType LineValidityPeriod
    {
        get => lineValidityPeriodField;
        set => lineValidityPeriodField = value;
    }

    /// <remarks />
    [XmlElement("RequiredItemLocationQuantity")]
    public ItemLocationQuantityType[] RequiredItemLocationQuantity
    {
        get => requiredItemLocationQuantityField;
        set => requiredItemLocationQuantityField = value;
    }

    /// <remarks />
    public ItemType Item
    {
        get => itemField;
        set => itemField = value;
    }
}