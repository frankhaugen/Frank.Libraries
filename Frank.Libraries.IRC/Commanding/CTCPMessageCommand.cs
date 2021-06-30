namespace Frank.Libraries.IRC.Commanding
{
    public class CTCPMessageCommand : ICommand
    {
        public string Recipient { get; set; }
        public string Command { get; set; }
        public string Arguments { get; set; }

        public CTCPMessageCommand()
        {
            Recipient = string.Empty;
            Command = string.Empty;
            Arguments = string.Empty;
        }
    }
}