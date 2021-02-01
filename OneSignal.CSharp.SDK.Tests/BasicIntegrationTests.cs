using System;
using System.Collections.Generic;
using OneSignal.CSharp.SDK.Core;
using OneSignal.CSharp.SDK.Core.Resources;
using OneSignal.CSharp.SDK.Core.Resources.Notifications;
using Xunit;
using Xunit.Extensions.Ordering;

namespace OneSignal.CSharp.SDK.Tests
{
    [Order(1)]
    public class BasicIntegrationTests
    {
        [Fact,Order(1)]
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
