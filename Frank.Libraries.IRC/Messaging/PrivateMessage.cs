namespace Frank.Libraries.IRC.Messaging
{
    public class PrivateMessage : IMessage
    {
        public Nick Sender { get; set; }
        public string Message { get; set; }
    }
}