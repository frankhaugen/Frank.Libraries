namespace Frank.Libraries.IRC.Commanding
{
    public class UserhostCommand : ICommand
    {
        public string Nicks { get; set; }

        public UserhostCommand()
        {
            Nicks = string.Empty;
        }
    }
}