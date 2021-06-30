namespace Frank.Libraries.IRC.Commanding
{
    public class NickCommand : ICommand
    {
        public string Nick { get; set; }

        public NickCommand()
        {
            Nick = string.Empty;
        }
    }
}