namespace Frank.Libraries.IRC.Commanding
{
    public class TraceCommand : ICommand
    {
        public string Target { get; set; }

        public TraceCommand()
        {
            Target = string.Empty;
        }
    }
}