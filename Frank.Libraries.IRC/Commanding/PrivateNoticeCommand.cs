namespace Frank.Libraries.IRC.Commanding
{
    public class PrivateNoticeCommand : ICommand
    {
        public string Recipient { get; set; }
        public string Message { get; set; }

        public PrivateNoticeCommand()
        {
            Recipient = string.Empty;
            Message = string.Empty;
        }
    }
}