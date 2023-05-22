using HidSharp;
using NodaTime;

namespace Frank.Libraries.Machine;

public class MachineInfo
{
    public string GetName() => Environment.MachineName;

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