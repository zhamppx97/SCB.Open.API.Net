using Newtonsoft.Json;
using RestSharp;
using SCB.Open.API.Net.Payments.BScanC.Models;
using SCB.Open.API.Net.Infrastructure;
using SCB.Open.API.Net.Settings;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.BScanC.Services
{
    public class BScanCService : IBScanCService
    {
        private readonly AppSettings _appSettings = new AppSettings();
        private readonly string _remoteServiceBaseUrl;

        public BScanCService()
        {
            _remoteServiceBaseUrl = $"{_appSettings.BaseApiUrl}";
        }

        public MerchantRtpConfirmResponseData GetMerchantRtpConfirm(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.BScanC.Confirm(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", merchantRtpConfirmRequestHeader.ContentType);
            request.AddHeader("authorization", merchantRtpConfirmRequestHeader.Authorization);
            request.AddHeader("resourceOwnerId", merchantRtpConfirmRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", merchantRtpConfirmRequestHeader.RequestUId);
            request.AddHeader("accept-language", merchantRtpConfirmRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(merchantRtpConfirmRequestBody));

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<MerchantRtpConfirmResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<MerchantRtpConfirmResponseData> GetMerchantRtpConfirmAsync(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.BScanC.Confirm(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", merchantRtpConfirmRequestHeader.ContentType);
            request.AddHeader("authorization", merchantRtpConfirmRequestHeader.Authorization);
            request.AddHeader("resourceOwnerId", merchantRtpConfirmRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", merchantRtpConfirmRequestHeader.RequestUId);
            request.AddHeader("accept-language", merchantRtpConfirmRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(merchantRtpConfirmRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<MerchantRtpConfirmResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }
    }
}
