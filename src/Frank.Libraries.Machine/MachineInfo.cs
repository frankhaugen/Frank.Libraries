using System;
using System.Collections.Generic;
using System.Linq;
using HidSharp;
using NodaTime;

namespace Frank.Libraries.Machine
{
    public class MachineInfo
    {
        public string GetName() => System.Environment.MachineName;

        //public bool CheckPlatform(PlatformID platform) => GetPlatform() == platform;

        //public void DOIT() => Local

        public string GetUserName() => Environment.UserName;

        public string GetMachineName() => Environment.MachineName;

        public Version GetOsVersion() => Environment.OSVersion.Version;

        public OperatingSystem GetOperatingSystem() => Environment.OSVersion;

        public PlatformID GetPlatformId() => Environment.OSVersion.Platform;

        public bool Is64Bit() => Environment.Is64BitOperatingSystem;

        public TimeSpan Uptime() => TimeSpan.FromTicks(Environment.TickCount64);

        public List<Device> GetDeviceList() => DeviceList.Local.GetAllDevices()
                                                         .ToList();

        public DateTimeOffset GetSystemTime() => SystemClock.Instance.GetCurrentInstant()
                                                            .ToDateTimeOffset();
    }

    public class DeviceInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FriendlyName { get; set; }
    }

    public static class DeviceExtension
    {
        public static DeviceInfo GetDeviceInfo(this Device device) => new()
        {
            Id = device.DevicePath,
            Name = device.GetFileSystemName(),
            FriendlyName = device.GetFriendlyName()
        };
    }
}