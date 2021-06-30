namespace Frank.Libraries.IRC.Commanding
{
    public class WhoisCommand : ICommand
    {
        public string Server { get; set; }
        public string Nick { get; set; }

        public WhoisCommand()
        {
            Server = string.Empty;
            Nick = string.Empty;
        }
    }
}