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
[XmlRoot("OrderedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class OrderedShipmentType
{
    private PackageType[] packageField;

    private ShipmentType shipmentField;

    /// <remarks />
    public ShipmentType Shipment
    {
        get => shipmentField;
        set => shipmentField = value;
    }

    /// <remarks />
    [XmlElement("Package")]
    public PackageType[] Package
    {
        get => packageField;
        set => packageField = value;
    }
}