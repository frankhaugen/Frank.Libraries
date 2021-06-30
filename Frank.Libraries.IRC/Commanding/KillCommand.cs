namespace Frank.Libraries.IRC.Commanding
{
    public class KillCommand : ICommand
    {
        public string Nick { get; set; }
        public string Comment { get; set; }

        public KillCommand()
        {
            Nick = string.Empty;
            Comment = string.Empty;
        }
    }
}