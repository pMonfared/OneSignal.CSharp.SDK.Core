using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneSignal.CSharp.SDK;
using OneSignal.CSharp.SDK.Resources.Notifications;
using System.Collections.Generic;
using OneSignal.CSharp.SDK.Resources;

namespace OneSignal_CSharp_SDK.Tests
{
    [TestClass]
    public class BasicIntegrationTests
    {
        [TestMethod]
        public void TestASimpleCall()
        {
            var client = new OneSignalClient(""); // Use your Api Key

            var options = new NotificationCreateOptions();

            options.AppId = new Guid("");   // Use your AppId
            options.IncludePlayerIds = new List<string>()
            {
                "00000000-0000-0000-0000-000000000000" // Use your playerId
            };
            options.Headings.Add(LanguageCodes.English, "New Notification!");
            options.Contents.Add(LanguageCodes.English, "This will push a real notification directly to your device.");

            client.Notifications.Create(options);
        }
    }
}
