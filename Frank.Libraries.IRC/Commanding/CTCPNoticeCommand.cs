namespace Frank.Libraries.IRC.Commanding
{
    public class CTCPNoticeCommand : ICommand
    {
        public string Recipient { get; set; }
        public string Command { get; set; }
        public string Arguments { get; set; }

        public CTCPNoticeCommand()
        {
            Recipient = string.Empty;
            Command = string.Empty;
            Arguments = string.Empty;
        }
    }
}