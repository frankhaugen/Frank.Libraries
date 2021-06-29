using System;
using H.Hooks;

namespace Frank.Libraries.Machine
{
    public class MachineInfo
    {
        public string GetName() => Environment.MachineName;

        //public bool CheckPlatform(PlatformID platform) => GetPlatform() == platform;

        //public void DOIT() => Local

        public string GetUserName() => Environment.UserName;

        public Version GetOsVersion() => Environment.OSVersion.Version;

        //public PlatformID GetPlatform() => Environment.OSVersion.Platform;

        public bool Is64Bit() => Environment.Is64BitOperatingSystem;

        public TimeSpan Uptime() => TimeSpan.FromTicks(Environment.TickCount64);
    }

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