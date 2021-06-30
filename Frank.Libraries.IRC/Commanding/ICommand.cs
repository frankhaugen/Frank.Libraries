using System;

namespace Frank.Libraries.IRC.Commanding
{
    abstract public class ICommand : EventArgs
    {
        public DateTime TimeStamp { get; set; }

        public ICommand()
        {
            TimeStamp = DateTime.Now;
        }
    }
}