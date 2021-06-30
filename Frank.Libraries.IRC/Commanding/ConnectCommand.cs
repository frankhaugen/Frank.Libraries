namespace Frank.Libraries.IRC.Commanding
{
    public class ConnectCommand : ICommand
    {
        public string Originator { get; set; }
        public int Port { get; set; }
        public string Server { get; set; }

        public ConnectCommand()
        {
            Originator = string.Empty;
            Port = 0;
            Server = string.Empty;
        }
    }
}