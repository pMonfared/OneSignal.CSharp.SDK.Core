using OneSignal.CSharp.SDK.Core.Resources.Devices;
using OneSignal.CSharp.SDK.Core.Resources.Notifications;

namespace OneSignal.CSharp.SDK.Core
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
