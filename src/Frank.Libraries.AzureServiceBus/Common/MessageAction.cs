namespace Frank.Libraries.AzureServiceBus.Common;

public enum MessageAction
{
    Complete,
    Abandon,
    DeadLetter,
    Defer
}