using System;

namespace Frank.Libraries.IRC.Messaging
{
    abstract public class IMessage : EventArgs
    {
        public DateTime TimeStamp { get; set; }

        public IMessage()
        {
            TimeStamp = DateTime.Now;
        }
    }

    // IRC Reply Codes //

    // IRC Error Codes //
}
