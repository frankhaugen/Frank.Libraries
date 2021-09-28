using System;
using H.Hooks;

namespace Frank.Libraries.Machine
{
    public class Inputs
    {
        public void MonitorInput()
        {
            using var keyboardHook = new LowLevelKeyboardHook();
            using var mouseHook = new LowLevelMouseHook();

            keyboardHook.Start();
            mouseHook.Start();

            keyboardHook.Down += (sender, args) => Console.WriteLine(args.Keys);
            mouseHook.Down += (sender, args) => Console.WriteLine(args.Keys);

            do
            {
            } while (keyboardHook.IsStarted && mouseHook.IsStarted);
        }
    }
}