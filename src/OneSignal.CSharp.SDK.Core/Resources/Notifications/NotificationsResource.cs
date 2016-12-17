using OneSignal.CSharp.SDK.Core.Serializers;
using RestSharp;

namespace OneSignal.CSharp.SDK.Core.Resources.Notifications
{
    public class NotificationsResource : BaseResource, INotificationsResource
    {
        public NotificationsResource(string apiKey, string apiUri) : base(apiKey, apiUri)
        {
        }

        public NotificationCreateResult Create(NotificationCreateOptions options)
        {
            RestRequest restRequest = new RestRequest("notifications", Method.POST);

            restRequest.AddHeader("Authorization", string.Format("Basic {0}", base.ApiKey));

            restRequest.RequestFormat = DataFormat.Json;
            restRequest.JsonSerializer = new NewtonsoftJsonSerializer();
            restRequest.AddBody(options);

            IRestResponse<NotificationCreateResult> restResponse = base.RestClient.Execute<NotificationCreateResult>(restRequest);

            if (restResponse.ErrorException != null)
            {
                throw restResponse.ErrorException;
            }

            return restResponse.Data;
        }
    }
}
