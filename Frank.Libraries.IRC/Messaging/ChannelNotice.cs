namespace Frank.Libraries.IRC.Messaging
{
    public class ChannelNotice : IMessage
    {
        public string Channel { get; set; }
        public Nick Sender { get; set; }
        public string Message { get; set; }
    }
}