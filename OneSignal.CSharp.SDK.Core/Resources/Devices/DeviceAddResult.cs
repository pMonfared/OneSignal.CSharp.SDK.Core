﻿using RestSharp.Deserializers;

namespace OneSignal.CSharp.SDK.Core.Resources.Devices
{
    /// <summary>
    /// Class used to keep result of device add operation.
    /// </summary>
    public class DeviceAddResult
    {
        /// <summary>
        /// Returns true if operation is successfull.
        /// </summary>
        [DeserializeAs(Name = "success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Returns id of the result operation.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
