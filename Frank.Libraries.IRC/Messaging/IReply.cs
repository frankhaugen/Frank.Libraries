namespace Frank.Libraries.IRC.Messaging
{
    abstract public class IReply : IMessage
    {
        public string Message { get; set; }
    }
}