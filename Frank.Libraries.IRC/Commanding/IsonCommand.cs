namespace Frank.Libraries.IRC.Commanding
{
    public class IsonCommand : ICommand
    {
        public string Nicks { get; set; }

        public IsonCommand()
        {
            Nicks = string.Empty;
        }
    }
}