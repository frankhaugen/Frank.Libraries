namespace Frank.Libraries.IRC.Commanding
{
    public class WhowasCommand : ICommand
    {
        public string Nick { get; set; }
        public int Entries { get; set; }
        public string Server { get; set; }

        public WhowasCommand()
        {
            Nick = string.Empty;
            Entries = 0;
            Server = string.Empty;
        }
    }
}