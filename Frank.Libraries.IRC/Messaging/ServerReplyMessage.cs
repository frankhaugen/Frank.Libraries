namespace Frank.Libraries.IRC.Messaging
{
    public class ServerReplyMessage : IReply
    {
        public IRCReplyCode ReplyCode { get; set; }
    }
}