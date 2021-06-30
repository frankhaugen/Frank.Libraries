namespace Frank.Libraries.IRC.Commanding
{
    public class NamesCommand : ICommand
    {
        public string Channel { get; set; }

        public NamesCommand()
        {
            Channel = string.Empty;
        }
    }
}