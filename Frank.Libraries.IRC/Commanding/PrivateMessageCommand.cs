namespace Frank.Libraries.IRC.Commanding
{
    public class PrivateMessageCommand : ICommand
    {
        public string Recipient { get; set; }
        public string Message { get; set; }

        public PrivateMessageCommand()
        {
            Recipient = string.Empty;
            Message = string.Empty;
        }
    }
}