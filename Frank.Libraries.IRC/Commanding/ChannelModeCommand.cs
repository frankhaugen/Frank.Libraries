namespace Frank.Libraries.IRC.Commanding
{
    public class ChannelModeCommand : ICommand
    {
        public string Channel { get; set; }
        public ChannelModeInfo Mode { get; set; }

        public ChannelModeCommand()
        {
            Channel = string.Empty;
            Mode = new ChannelModeInfo();
        }
    }
}