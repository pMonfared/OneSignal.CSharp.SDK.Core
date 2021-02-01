﻿using RestSharp.Deserializers;

namespace OneSignal.CSharp.SDK.Core.Resources.Notifications
{
    /// <summary>
    /// Result of notification create operation.
    /// </summary>
    public class NotificationCreateResult
    {
        /// <summary>
        /// Returns the number of recepients who received the message.
        /// </summary>
        [DeserializeAs(Name = "recipients")]
        public int Recipients { get; set; }

        /// <summary>
        /// Returns the id of the result.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
