namespace Frank.Libraries.IRC.Commanding
{
    public class PongCommand : ICommand
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }

        public PongCommand()
        {
            Sender = string.Empty;
            Recipient = string.Empty;
        }
    }
}