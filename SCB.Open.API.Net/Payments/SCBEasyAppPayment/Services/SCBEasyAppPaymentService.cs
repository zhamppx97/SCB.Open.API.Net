using Newtonsoft.Json;
using RestSharp;
using SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models;
using SCB.Open.API.Net.Infrastructure;
using SCB.Open.API.Net.Settings;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.SCBEasyAppPayment.Services
{
    public class SCBEasyAppPaymentService : ISCBEasyAppPaymentService
    {
        private readonly AppSettings _appSettings = new AppSettings();
        private readonly string _remoteServiceBaseUrl;

        public SCBEasyAppPaymentService()
        {
            _remoteServiceBaseUrl = $"{_appSettings.BaseApiUrl}";
        }

        public DeepLinkTransactionsResponseData GetDeepLinkTransactions(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.SCBEasyAppPayment.DeeplinkTransactions(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", deepLinkTransactionsRequestHeader.ContentType);
            request.AddHeader("authorization", deepLinkTransactionsRequestHeader.Authorization);
            request.AddHeader("accept-language", deepLinkTransactionsRequestHeader.AcceptLanguage);
            request.AddHeader("resourceOwnerId", deepLinkTransactionsRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", deepLinkTransactionsRequestHeader.RequestUId);
            request.AddHeader("channel", deepLinkTransactionsRequestHeader.Channel);
            request.AddJsonBody(JsonConvert.SerializeObject(deepLinkTransactionsRequestBody));

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<DeepLinkTransactionsResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<DeepLinkTransactionsResponseData> GetDeepLinkTransactionsAsync(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.SCBEasyAppPayment.DeeplinkTransactions(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", deepLinkTransactionsRequestHeader.ContentType);
            request.AddHeader("authorization", deepLinkTransactionsRequestHeader.Authorization);
            request.AddHeader("accept-language", deepLinkTransactionsRequestHeader.AcceptLanguage);
            request.AddHeader("resourceOwnerId", deepLinkTransactionsRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", deepLinkTransactionsRequestHeader.RequestUId);
            request.AddHeader("channel", deepLinkTransactionsRequestHeader.Channel);
            request.AddJsonBody(JsonConvert.SerializeObject(deepLinkTransactionsRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<DeepLinkTransactionsResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }
    }
}
