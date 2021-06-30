namespace Frank.Libraries.IRC.Messaging
{
    public class PrivateNotice : IMessage
    {
        public Nick Sender { get; set; }
        public string Message { get; set; }
    }
}