using Newtonsoft.Json;
using RestSharp;
using SCB.Open.API.Net.Customer.Information.Models;
using SCB.Open.API.Net.Infrastructure;
using SCB.Open.API.Net.Settings;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Customer.Information.Services
{
    public class CustomerInfoService : ICustomerInfoService
    {
        private readonly AppSettings _appSettings = new AppSettings();
        private readonly string _remoteServiceBaseUrl;

        public CustomerInfoService()
        {
            _remoteServiceBaseUrl = $"{_appSettings.BaseApiUrl}";
        }

        public CustomerInfoResponseData GetProfile(CustomerInfoRequestHeader customerInfoRequestHeader)
        {
            var client = new RestClient(OpenAPI.CustomerInfo.Profile(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", customerInfoRequestHeader.Authorization);
            request.AddHeader("resourceOwnerId", customerInfoRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", customerInfoRequestHeader.RequestUId);
            request.AddHeader("accept-language", customerInfoRequestHeader.AcceptLanguage);

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<CustomerInfoResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<CustomerInfoResponseData> GetProfileAsync(CustomerInfoRequestHeader customerInfoRequestHeader)
        {
            var client = new RestClient(OpenAPI.CustomerInfo.Profile(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", customerInfoRequestHeader.Authorization);
            request.AddHeader("resourceOwnerId", customerInfoRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", customerInfoRequestHeader.RequestUId);
            request.AddHeader("accept-language", customerInfoRequestHeader.AcceptLanguage);

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<CustomerInfoResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }
    }
}
