namespace Frank.Libraries.IRC.Commanding
{
    public class QuitCommand : ICommand
    {
        public string Message { get; set; }

        public QuitCommand()
        {
            Message = string.Empty;
        }
    }
}