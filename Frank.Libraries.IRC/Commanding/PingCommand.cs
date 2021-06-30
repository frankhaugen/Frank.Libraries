namespace Frank.Libraries.IRC.Commanding
{
    public class PingCommand : ICommand
    {
        public string Recipient { get; set; }

        public PingCommand()
        {
            Recipient = string.Empty;
        }
    }
}