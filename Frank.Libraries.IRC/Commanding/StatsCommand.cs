namespace Frank.Libraries.IRC.Commanding
{
    public class StatsCommand : ICommand
    {
        public string Stat { get; set; }
        public string Parameter { get; set; }

        public StatsCommand()
        {
            Stat = string.Empty;
            Parameter = string.Empty;
        }
    }
}