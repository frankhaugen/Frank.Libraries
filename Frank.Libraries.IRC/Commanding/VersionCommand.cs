namespace Frank.Libraries.IRC.Commanding
{
    public class VersionCommand : ICommand
    {
        public string Server { get; set; }

        public VersionCommand()
        {
            Server = string.Empty;
        }
    }
}