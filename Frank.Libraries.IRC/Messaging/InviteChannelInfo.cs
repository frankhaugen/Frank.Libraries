namespace Frank.Libraries.IRC.Messaging
{
    public class InviteChannelInfo : IMessage
    {
        public string Channel { get; set; }
        public Nick Requester { get; set; }
        public Nick Recipient { get; set; }
    }
}