using RestSharp;

namespace OneSignal.CSharp.SDK.Core.Resources
{
    public abstract class BaseResource
    {
        protected RestClient RestClient { get; set; }

        protected string ApiKey { get; set; }

        public BaseResource(string apiKey, string apiUri)
        {
            ApiKey = apiKey;
            RestClient = new RestClient(apiUri);
        }
    }
}
