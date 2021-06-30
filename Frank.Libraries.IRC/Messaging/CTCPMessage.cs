namespace Frank.Libraries.IRC.Messaging
{
    public class CTCPMessage : IMessage
    {
        public string Location { get; set; }
        public Nick Sender { get; set; }
        public string Command { get; set; }
        public string Arguments { get; set; }
    }
}