using OneSignal.CSharp.SDK.Resources.Notifications;
using OneSignal.CSharp.SDK.Resources.Devices;

namespace OneSignal.CSharp.SDK
{
    /// <summary>
    /// OneSignal client interface.
    /// </summary>
    public interface IOneSignalClient
    {
        /// <summary>
        /// Device resources.
        /// </summary>
        IDevicesResource Devices { get; }

        /// <summary>
        /// Notification resources.
        /// </summary>
        INotificationsResource Notifications { get; }
    }
}
