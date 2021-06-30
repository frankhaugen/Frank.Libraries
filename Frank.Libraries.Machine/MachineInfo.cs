using System;

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
}