using Newtonsoft.Json;
using RestSharp;
using SCB.Open.API.Net.Infrastructure;
using SCB.Open.API.Net.Payments.EWallets.Models;
using SCB.Open.API.Net.Settings;
using System.Threading.Tasks;

namespace SCB.Open.API.Net.Payments.EWallets.Services
{
    public class EWalletsService : IEWalletsService
    {
        private readonly AppSettings _appSettings = new AppSettings();
        private readonly string _remoteServiceBaseUrl;

        public EWalletsService()
        {
            _remoteServiceBaseUrl = $"{_appSettings.BaseApiUrl}";
        }

        public QRCodeCreateResponseData GetQRCodeCreate(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.EWallets.QRCodeCreate(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", qRCodeCreateRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", qRCodeCreateRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", qRCodeCreateRequestHeader.RequestUId);
            request.AddHeader("authorization", qRCodeCreateRequestHeader.Authorization);
            request.AddHeader("accept-language", qRCodeCreateRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(qRCodeCreateRequestBody));

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<QRCodeCreateResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<QRCodeCreateResponseData> GetQRCodeCreateAsync(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.EWallets.QRCodeCreate(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", qRCodeCreateRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", qRCodeCreateRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", qRCodeCreateRequestHeader.RequestUId);
            request.AddHeader("authorization", qRCodeCreateRequestHeader.Authorization);
            request.AddHeader("accept-language", qRCodeCreateRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(qRCodeCreateRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<QRCodeCreateResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public InquireResponseData GetInquire(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.EWallets.Inquire(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", inquireRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", inquireRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", inquireRequestHeader.RequestUId);
            request.AddHeader("authorization", inquireRequestHeader.Authorization);
            request.AddHeader("accept-language", inquireRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(inquireRequestBody));

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<InquireResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<InquireResponseData> GetInquireAsync(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.EWallets.Inquire(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", inquireRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", inquireRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", inquireRequestHeader.RequestUId);
            request.AddHeader("authorization", inquireRequestHeader.Authorization);
            request.AddHeader("accept-language", inquireRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(inquireRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<InquireResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public CancelResponseData GetCancel(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.EWallets.Cancel(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", cancelRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", cancelRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", cancelRequestHeader.RequestUId);
            request.AddHeader("authorization", cancelRequestHeader.Authorization);
            request.AddHeader("accept-language", cancelRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(cancelRequestBody));

            IRestResponse response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<CancelResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }

        public async Task<CancelResponseData> GetCancelAsync(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody)
        {
            var client = new RestClient(OpenAPI.Payments.EWallets.Cancel(_remoteServiceBaseUrl))
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", cancelRequestHeader.ContentType);
            request.AddHeader("resourceOwnerId", cancelRequestHeader.ResourceOwnerId);
            request.AddHeader("requestUId", cancelRequestHeader.RequestUId);
            request.AddHeader("authorization", cancelRequestHeader.Authorization);
            request.AddHeader("accept-language", cancelRequestHeader.AcceptLanguage);
            request.AddJsonBody(JsonConvert.SerializeObject(cancelRequestBody));

            IRestResponse response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<CancelResponseData>(response.Content);
            var responseJsonString = JsonConvert.DeserializeObject(response.Content);
            var results = responseContent;
            results.jsonString = responseJsonString;
            return results;
        }
    }
}
