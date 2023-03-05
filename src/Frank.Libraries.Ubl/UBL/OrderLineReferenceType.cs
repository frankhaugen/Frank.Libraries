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
[XmlRoot("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class OrderLineReferenceType
{
    private LineIDType lineIDField;

    private LineStatusCodeType lineStatusCodeField;

    private OrderReferenceType orderReferenceField;

    private SalesOrderLineIDType salesOrderLineIDField;

    private UUIDType uUIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineIDType LineID
    {
        get => lineIDField;
        set => lineIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SalesOrderLineIDType SalesOrderLineID
    {
        get => salesOrderLineIDField;
        set => salesOrderLineIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineStatusCodeType LineStatusCode
    {
        get => lineStatusCodeField;
        set => lineStatusCodeField = value;
    }

    /// <remarks />
    public OrderReferenceType OrderReference
    {
        get => orderReferenceField;
        set => orderReferenceField = value;
    }
}