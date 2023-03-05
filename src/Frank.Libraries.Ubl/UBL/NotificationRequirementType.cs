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
[XmlRoot("NotificationRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class NotificationRequirementType
{
    private LocationType1[] notificationLocationField;

    private PeriodType[] notificationPeriodField;

    private NotificationTypeCodeType notificationTypeCodeField;

    private PartyType[] notifyPartyField;

    private PostEventNotificationDurationMeasureType postEventNotificationDurationMeasureField;

    private PreEventNotificationDurationMeasureType preEventNotificationDurationMeasureField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NotificationTypeCodeType NotificationTypeCode
    {
        get => notificationTypeCodeField;
        set => notificationTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PostEventNotificationDurationMeasureType PostEventNotificationDurationMeasure
    {
        get => postEventNotificationDurationMeasureField;
        set => postEventNotificationDurationMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreEventNotificationDurationMeasureType PreEventNotificationDurationMeasure
    {
        get => preEventNotificationDurationMeasureField;
        set => preEventNotificationDurationMeasureField = value;
    }

    /// <remarks />
    [XmlElement("NotifyParty")]
    public PartyType[] NotifyParty
    {
        get => notifyPartyField;
        set => notifyPartyField = value;
    }

    /// <remarks />
    [XmlElement("NotificationPeriod")]
    public PeriodType[] NotificationPeriod
    {
        get => notificationPeriodField;
        set => notificationPeriodField = value;
    }

    /// <remarks />
    [XmlElement("NotificationLocation")]
    public LocationType1[] NotificationLocation
    {
        get => notificationLocationField;
        set => notificationLocationField = value;
    }
}