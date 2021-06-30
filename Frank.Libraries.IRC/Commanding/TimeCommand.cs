namespace Frank.Libraries.IRC.Commanding
{
    public class TimeCommand : ICommand
    {
        public string Server { get; set; }

        public TimeCommand()
        {
            Server = string.Empty;
        }
    }
}