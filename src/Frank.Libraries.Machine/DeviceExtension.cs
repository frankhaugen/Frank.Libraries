using HidSharp;

namespace Frank.Libraries.Machine;

public static class DeviceExtension
{
    public static DeviceInfo GetDeviceInfo(this Device device) => new()
    {
        Id = device.DevicePath,
        Name = device.GetFileSystemName(),
        FriendlyName = device.GetFriendlyName()
    };
}