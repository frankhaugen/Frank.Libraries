namespace Frank.Libraries.IRC.Messaging
{
    public class ChannelMessage : IMessage
    {
        public string Channel { get; set; }
        public Nick Sender { get; set; }
        public string Message { get; set; }
    }
}