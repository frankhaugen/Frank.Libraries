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
[XmlRoot("DependentPriceReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DependentPriceReferenceType
{
    private LineReferenceType dependentLineReferenceField;

    private AddressType locationAddressField;

    private PercentType1 percentField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PercentType1 Percent
    {
        get => percentField;
        set => percentField = value;
    }

    /// <remarks />
    public AddressType LocationAddress
    {
        get => locationAddressField;
        set => locationAddressField = value;
    }

    /// <remarks />
    public LineReferenceType DependentLineReference
    {
        get => dependentLineReferenceField;
        set => dependentLineReferenceField = value;
    }
}