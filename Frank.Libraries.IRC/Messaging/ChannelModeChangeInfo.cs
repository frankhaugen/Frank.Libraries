using System.Collections.Generic;

namespace Frank.Libraries.IRC.Messaging
{
    public class ChannelModeChangeInfo : IMessage
    {
        public string Channel { get; set; }
        public Nick Nick { get; set; }
        public List<ChannelModeInfo> Modes { get; set; }
    }
}