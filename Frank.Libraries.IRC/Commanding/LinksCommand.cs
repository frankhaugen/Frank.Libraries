namespace Frank.Libraries.IRC.Commanding
{
    public class LinksCommand : ICommand
    {
        public string Mask { get; set; }
        public string Server { get; set; }

        public LinksCommand()
        {
            Mask = string.Empty;
            Server = string.Empty;
        }
    }
}