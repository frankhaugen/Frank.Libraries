using System.Collections.Generic;

namespace Frank.Libraries.IRC.Messaging
{
    public class UserModeChangeInfo : IMessage
    {
        public Nick Nick { get; set; }
        public List<UserModeInfo> Modes { get; set; }
    }
}