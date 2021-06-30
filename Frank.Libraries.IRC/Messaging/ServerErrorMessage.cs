namespace Frank.Libraries.IRC.Messaging
{
    public class ServerErrorMessage : IReply
    {
        public IRCErrorCode ErrorCode { get; set; }
    }
}