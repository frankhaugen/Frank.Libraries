namespace Frank.Libraries.IRC.Commanding
{
    public class SummonCommand : ICommand
    {
        public string Nick { get; set; }
        public string Host { get; set; }

        public SummonCommand()
        {
            Nick = string.Empty;
            Host = string.Empty;
        }
    }
}