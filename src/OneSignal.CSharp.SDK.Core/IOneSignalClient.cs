using OneSignal.CSharp.SDK.Core.Resources.Notifications;
using OneSignal.CSharp.SDK.Core.Resources.Devices;

namespace OneSignal.CSharp.SDK.Core
{
    public interface IOneSignalClient
    {
        IDevicesResource Devices { get; }

        INotificationsResource Notifications { get; }
    }
}
